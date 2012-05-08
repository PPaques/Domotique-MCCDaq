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
            // verifying and setting the card
            MyCard = new Card();
            GlobalVariables.mode = "simulation";
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
            
            // selecting the fire
            FireHotPannel Fire_panel = null;
            switch (RoomId)
            {
                case 1:
                    Fire_panel = fireHotSaloon;
                    break;
                case 2:
                    Fire_panel = fireHotKitchen;
                    break;
                case 3:
                    Fire_panel = fireHotBedRoom;
                    break;
                default:
                    MessageBox.Show("Error at Change Hot State (Room ID out of range)");
                    break;
            }

            GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active = !GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active;
            Fire_panel.Visible = GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active;
            if (GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active)
            {
                (sender as Button).Text = "On";
            }
            else
            {
                (sender as Button).Text = "Off";
            }

        }

       
        /// <summary>
        /// Change the light state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeLightState(object sender, EventArgs e)
        {
            GlobalVariables.MyHouse.Rooms[0].light_is_active = !GlobalVariables.MyHouse.Rooms[0].light_is_active;
            lighActivePanel.Visible = GlobalVariables.MyHouse.Rooms[0].light_is_active;
            if (GlobalVariables.MyHouse.Rooms[0].light_is_active)
            {
                (sender as Button).Text = "On";
            }
            else
            {
                (sender as Button).Text = "Off";
            }
        }

        /// <summary>
        /// In simulation mode we have to enable all textboxes
        /// </summary>
        private void SetView() 
        {
            if (GlobalVariables.mode == "simulation")
            {
                // all the opening
                this.BtWindowKitchen.Enabled = true;
                this.BtWindowBedroom.Enabled = true;
                this.BtWindowSaloonL.Enabled = true;
                this.BtWindowSaloonR.Enabled = true;

                this.BtDoorKitchen.Enabled = true;
                this.BtDoorBedroom.Enabled = true;
                this.BtDoorEnter.Enabled = true;

                // kitchen
                this.BtKitchenHot.Enabled = true;
                this.tBKitchenTempAct.Enabled = true;

                // bedroom
                this.BtBedRoomHot.Enabled = true;
                this.tBBedRoomTempAct.Enabled = true;

                // saloon
                this.BtSaloonHot.Enabled = true;
                this.tBSaloonTempAct.Enabled = true;

                // exterior
                this.tBOutdoorTempAct.Enabled = true;
                this.BtOutdoorLight.Enabled = true;
            }
        }

        /// <summary>
        /// force the temperature change with the view when press enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForceChangeTempSim(object sender, KeyPressEventArgs e)
        {
            // inf we press enter, we change the value
            if (e.KeyChar == (char)13)
            {
                //verify the data
                if (Functions.TemperatureRange((sender as TextBox).Text,-50,50))
                { 
                    // change in model
                    GlobalVariables.MyHouse.Rooms[Convert.ToInt16((sender as TextBox).Tag)].temperature = Convert.ToDouble((sender as TextBox).Text);
                    // change in the view
                    Functions.changeTempView(Convert.ToInt16((sender as TextBox).Tag), (sender as TextBox).Text);
                }

            }
        }

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
                TimerFunctions.StatesModelToView();
            }
            if (GlobalVariables.mode == "simulation") 
            {
                TimerFunctions.TempViewToModel();
                TimerFunctions.StatesViewToModel();
            }

           

            // *--------------------------------------------------------
            // *            taking the temperature                     *
            // *--------------------------------------------------------
            // if we are in simulation mode, we calculate every secondes, if normal mode, we take every min
            if (GlobalVariables.mode == "simulation")
            {
                // calculate and send it to the model
                //TimerFunctions.calculate_next_temp();
            }

            // 60 sec = 1 min
            if (routine_count >= 60 && GlobalVariables.mode == "normal")
            {
                MyCard.ReadTemp();
                // resetting the routine counter
                routine_count = -1;
            }

            // actualise the temperatures from the model
            TimerFunctions.TempModelToView();



            // *--------------------------------------------------------
            // *                Hotter regulation                      *
            // *--------------------------------------------------------
            // start the regulation (the hot system on or off ? )
            TimerFunctions.regulation();
            
            routine_count++;
        }

        /// <summary>
        /// Function to enable the routine of regulation (Need to fix that because we just have to make a FORCE mode)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartTimerMainRoutine(object sender, EventArgs e)
        {
            TimerMainRoutine.Enabled = !TimerMainRoutine.Enabled;

            if (TimerMainRoutine.Enabled)
            {
                MenuBarRegulation.Text = "Arrêter la régulation";
            }
            else
            {
                MenuBarRegulation.Text = "Lancer la régulation";
            }

        }

        /// <summary>
        /// Print a clock for the house system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
