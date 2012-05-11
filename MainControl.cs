using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace MyhouseDomotique
{
    
    public partial class MainControl : Form
    {
        // global variables
        Card MyCard;
 
        /// <summary>
        /// Loading the form
        /// </summary>
        public MainControl()
        {
            InitializeComponent();
        }
 
        /// <summary>
        /// Initialising the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Initialisation(object sender, EventArgs e)
        {
            // configuring the defaults values
            GlobalVariables.MinTemp = 0;
            GlobalVariables.MaxTemp = 35;
            GlobalVariables.LightAutomatique = true; 
            GlobalVariables.RegulationActive = true;

            // verifying and setting the card
            MyCard = new Card();
            StatusBarMode.Text = "Mode "+ GlobalVariables.mode;

            
            // creating the house
            GlobalVariables.MyHouse = new House();

            // setting the view
            this.SetView();

            // connection to the db
            if (GlobalVariables.mode == "normal")
            {
                GlobalVariables.conn = new SqlCeConnection("Data Source = |DataDirectory|normal.sdf");
            }
            else 
            {
                GlobalVariables.conn = new SqlCeConnection("Data Source = |DataDirectory|simulation.sdf");        
            }
            GlobalVariables.conn.Open();

            // lancement de la regulation
            TimerMainRoutine.Enabled = true;

        }

        /// <summary>
        /// When we close the main window, we have to shut down the database link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit(object sender, FormClosingEventArgs e)
        {
            // Closing connection
            if (GlobalVariables.conn.State == ConnectionState.Open)
                GlobalVariables.conn.Close();
        }

        /// <summary>
        /// Functuon to quit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuBarClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
        /// <summary>
        /// Changing the state of all the openings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeOpeningState(object sender, EventArgs e)
        {
            if (((string)(sender as Button).Tag) == "open") 
            {
                (sender as Button).Tag = "close";
                (sender as Button).BackColor = System.Drawing.Color.Black;
            }
            else 
            {
                (sender as Button).Tag = "open";
                (sender as Button).BackColor = System.Drawing.Color.Maroon;
            }
        }

        /// <summary>
        /// Function that change the hot state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeHotState(object sender, EventArgs e)
        {
            int RoomId = Convert.ToInt32((sender as Button).Tag);
                    
            GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active = !GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active;

            Functions.SetHotStateView(RoomId);
        }
 
        /// <summary>
        /// Change the light state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeLightState(object sender, EventArgs e)
        {
            GlobalVariables.MyHouse.Rooms[0].light_is_active = !GlobalVariables.MyHouse.Rooms[0].light_is_active;
            Functions.SetLightState();
        }

        /// <summary>
        /// In simulation mode we have to enable all textboxes
        /// </summary>
        private void SetView() 
        {
            if (GlobalVariables.mode == "simulation")
            {
                // all the opening
                BtWindowKitchen.Enabled = true;
                BtWindowBedroom.Enabled = true;
                BtWindowSaloonL.Enabled = true;
                BtWindowSaloonR.Enabled = true;

                BtDoorKitchen.Enabled = true;
                BtDoorBedroom.Enabled = true;
                BtDoorEnter.Enabled = true;

                // kitchen
                tBKitchenTempAct.Enabled = true;

                // bedroom
                tBBedRoomTempAct.Enabled = true;

                // saloon
                tBSaloonTempAct.Enabled = true;
                
                // Outdoor
                tBOutdoorTempAct.Enabled = true;

                // configuration
                PanelLightConf.Enabled = false;
            }
        }

        // *-------------------------------------------------------------*
        // *        Mains timers (clock and routine)                     *
        // *-------------------------------------------------------------*
        /// <summary>
        /// This is the main timer, check all the states and temperature, calculate and do the regulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TMainRoutine_Tick(object sender, EventArgs e)
        {

            // *--------------------------------------------------------
            // *  taking the system states (door and windows)          *
            // *--------------------------------------------------------
            
            if (GlobalVariables.mode == "normal")
            {
                //checkstates by card
                MyCard.ReadStates();
            }
            if (GlobalVariables.mode == "simulation") 
            {
                TimerFunctions.TempViewToModel();
                TimerFunctions.StatesViewToModel();
            }
            TimerFunctions.TempOrderToModel();

            // *--------------------------------------------------------
            // *              Analysing the light status               *
            // *--------------------------------------------------------
            if (GlobalVariables.mode == "normal" && GlobalVariables.LightAutomatique)
            {
                GlobalVariables.MyHouse.Rooms[0].light_is_active = MyCard.IsDay();
            }

            // *--------------------------------------------------------
            // *            taking the temperature                     *
            // *--------------------------------------------------------
            // if we are in simulation mode, we calculate every secondes, if normal mode, we take every min
            if (GlobalVariables.mode == "simulation")
            {
                // calculate and send it to the model
                TimerFunctions.calculate_next_temp();
            }

            if (GlobalVariables.mode == "normal")
            {
                MyCard.ReadTemp();
            }


            // *--------------------------------------------------------
            // *                Hotter regulation                      *
            // *--------------------------------------------------------
            if (GlobalVariables.godMode == false && GlobalVariables.RegulationActive)
                TimerFunctions.regulation();

            // *--------------------------------------------------------
            // *             Sending the model to the view             *
            // *-------------------------------------------------------- 
            TimerFunctions.HotModelToView();
            TimerFunctions.TempModelToView();
            Functions.SetLightState();

            if (GlobalVariables.mode == "normal")
                TimerFunctions.StatesModelToView();

            // *--------------------------------------------------------
            // *  Sending the new states for hot and lum to the card   *
            // *-------------------------------------------------------- 
            if (GlobalVariables.mode == "normal")
            {
                MyCard.setHotStates();
                MyCard.setLightState();
            }

            // blink of record system
            StatusBarRecord.Visible = !StatusBarRecord.Visible;
        }

        /// <summary>
        /// Print a clock for the house system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm");
            if(GlobalVariables.mode == "simulation" && GlobalVariables.LightAutomatique)
            {
                if (Convert.ToDouble(DateTime.Now.ToString("HH")) < 19 && Convert.ToDouble(DateTime.Now.ToString("HH")) > 8)
                    GlobalVariables.MyHouse.Rooms[0].light_is_active = false;
                else
                    GlobalVariables.MyHouse.Rooms[0].light_is_active = true;
            
            }
            
        }

        // *-------------------------------------------------------------*
        // *             For the configuration                           *
        // *-------------------------------------------------------------*
        /// <summary>
        /// Change the automatic light system to the Globalvariables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeLightAuto(object sender, EventArgs e)
        {
            if (CbConfLightAuto.Checked)
            {
                GlobalVariables.LightAutomatique = true;
                BtOutdoorLight.Enabled = false;
            }
            else
            {
                GlobalVariables.LightAutomatique = false;
                BtOutdoorLight.Enabled = true;
            }
        }

        /// <summary>
        /// Function to enable the routine of regulation (Need to fix that because we just have to make a FORCE mode)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeRegulation(object sender, EventArgs e)
        {
            if (CbConfRegulation.Checked)
                GlobalVariables.RegulationActive = true;
            else
                GlobalVariables.RegulationActive = false;
        }

        /// <summary>
        /// function to change the configuration to the god mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeGodMode(object sender, EventArgs e)
        {
            if (CbConfGodMode.Checked)
            {
                GlobalVariables.godMode = true;
                BtSaloonHot.Enabled = true;
                BtKitchenHot.Enabled = true;
                BtBedRoomHot.Enabled = true;
                BtOutdoorLight.Enabled = true;
                CbConfRegulation.Enabled = false;
                CbConfRegulation.Checked = false;
                CbConfLightAuto.Checked = false;
                CbConfLightAuto.Enabled = false;
            }
            else
            {
                GlobalVariables.godMode = false;
                CbConfLightAuto.Checked = true;
                BtSaloonHot.Enabled = false;
                BtKitchenHot.Enabled = false;
                BtBedRoomHot.Enabled = false;
                BtOutdoorLight.Enabled = false;
                CbConfRegulation.Enabled = true;
                CbConfRegulation.Checked = true;
                CbConfLightAuto.Checked = true;
                CbConfLightAuto.Enabled = true;
            }
        }

        /// <summary>
        /// Exporting to excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtExportExcel_Click(object sender, EventArgs e)
        {
            int RoomChoice = 0;

            //Detect which radio button is checked
            if (RbExportOutdoor.Checked == true)
            {
                RoomChoice = Convert.ToInt16(RbExportOutdoor.Tag);
            }

            if (RbExportBedRoom.Checked == true)
            {
                RoomChoice = Convert.ToInt16(RbExportBedRoom.Tag);
            }

            if (RbExportSaloon.Checked == true)
            {
                RoomChoice = Convert.ToInt16(RbExportSaloon.Tag); ;
            }

            if (RbExportKitchen.Checked == true)
            {
                RoomChoice = Convert.ToInt16(RbExportKitchen.Tag); ;
            }

            if (RbExportAll.Checked == true)
            {
                RoomChoice = Convert.ToInt16(RbExportAll.Tag); ;
            }

            //Select the appropriate function to realise the exportation
            switch (RoomChoice)
            {
                case 4:
                    if (Convert.ToString((sender as Button).Tag) == "states")
                        Export.ExportStatesToExcelAll(dTPStart.Value,dTPEnd.Value);
                    else
                        Export.ExportTempToExcelAll(dTPStart.Value, dTPEnd.Value);
                    break;

                default:
                    if (Convert.ToString((sender as Button).Tag) == "states")
                        Export.ExportStatesToExcel(RoomChoice, dTPStart.Value, dTPEnd.Value);
                    else
                        Export.ExportTempToExcel(RoomChoice, dTPStart.Value, dTPEnd.Value);
                    break;
            }
        }

        /// <summary>
        /// set the today date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtSetToday_Click(object sender, EventArgs e)
        {
            dTPEnd.Value = System.DateTime.Now;
            dTPStart.Value = System.DateTime.Now.AddHours(-24);

        }

        /// <summary>
        /// Read the values in datePicker fields & check if is possible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dTP_ValueChanged(object sender, EventArgs e)
        {
            dTPStart.Format = DateTimePickerFormat.Long;
            dTPEnd.Format = DateTimePickerFormat.Long;
            String StartTime = dTPStart.Value.ToShortDateString();
            String EndTime = dTPEnd.Value.ToShortDateString();

            if (dTPStart.Value > dTPEnd.Value)
                MessageBox.Show("Date de début ultérieure à date de fin !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
