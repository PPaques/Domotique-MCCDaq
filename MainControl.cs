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
        private int routine_count = 0;
 
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
            // TODO: This line of code loads data into the 'simulationDataSet.States_History' table. You can move, or remove it, as needed.
            this.states_HistoryTableAdapter.Fill(this.simulationDataSet.States_History);
            // TODO: This line of code loads data into the 'simulationDataSet.Temperatures_History' table. You can move, or remove it, as needed.
            this.temperatures_HistoryTableAdapter.Fill(this.simulationDataSet.Temperatures_History);
            // configuring the defaults values
            GlobalVariables.MinTemp = 0;
            GlobalVariables.MaxTemp = 35;
            GlobalVariables.LightAutomatique = true;

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

            // 60 sec = 1 min
            if (routine_count <= 0 && GlobalVariables.mode == "normal")
            {
                MyCard.ReadTemp();
                routine_count = 1; // time between the measures
            }


            // *--------------------------------------------------------
            // *                Hotter regulation                      *
            // *--------------------------------------------------------
            if (GlobalVariables.godMode == false)
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

            routine_count--;
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
                TimerMainRoutine.Enabled = true;
            else
                TimerMainRoutine.Enabled = false;
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
                CbConfLightAuto.Checked = false;
            }
            else
            {
                GlobalVariables.godMode = false;
                CbConfLightAuto.Checked = true;
                BtSaloonHot.Enabled = false;
                BtKitchenHot.Enabled = false;
                BtBedRoomHot.Enabled = false;
                BtOutdoorLight.Enabled = false;
            }
        }

    }
}
