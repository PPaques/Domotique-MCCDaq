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
        House myHouse;
        private int routine_count = 0;
 
        /// <summary>
        /// Loading the form
        /// </summary>
        public MainControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// changing the temperature with the textbox and progressbar
        /// </summary>
        /// <param name="RoomId"></param>
        /// <param name="Value"></param>
        public void changeTempView(int RoomId,string getValue)
        {
            VertcicalProgressBar ProgressBar = null;
            TextBox Tbtemp = null;
            double min = 10;
            double max = 30;
            double value = min;

            if (getValue == "HI")
            {
                value = max;
            }
            else
            {
                value = Convert.ToDouble(getValue);
            }


            
            switch (RoomId)
            {
                case 0:
                    ProgressBar = ProgressBarOutdoor;
                    Tbtemp = tBOutdoorTempAct;
                    break;
                case 1:
                    ProgressBar = ProgressBarSaloon;
                    Tbtemp = tBSaloonTempAct;
                    break;
                case 2:
                    ProgressBar = ProgressBarKitchen;
                    Tbtemp = tBKitchenTempAct;
                    break;
                case 3:
                    ProgressBar = ProgressBarBedRoom;
                    Tbtemp = tBBedRoomTempAct;
                    break;
                default:
                    MessageBox.Show("Error at Change Hot State (Room ID out of range)");
                    break;
            }

            if (value < min)
            {
                Tbtemp.Text  = "LO";
                ProgressBar.Value = 0;
            }
            else if (value > max)
            {
                Tbtemp.Text = "HI";
                ProgressBar.Value = 100;
            }
            else
            {
                Tbtemp.Text = Convert.ToString(getValue);
                ProgressBar.Value = Convert.ToInt16(((value - min) / (max - min)) * 100);
            }
        }

        /// <summary>
        /// Initialising the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Initialisation(object sender, EventArgs e)
        {
            // verifying and setting the card
            //MyCard = new Card();
            GlobalVariables.mode = "simulation";
            StatusBarMode.Text = "Mode "+ GlobalVariables.mode;

            
            // creating the house
            myHouse = new House();

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
            int WallId = Convert.ToInt32(Convert.ToString((sender as Button).Tag).Substring(0,1));
            int OpenId = Convert.ToInt32(Convert.ToString((sender as Button).Tag).Substring(1));

            if (myHouse.Walls[WallId].Openings[OpenId].isOpen)
            {
                myHouse.Walls[WallId].Openings[OpenId].isOpen = false;
                (sender as Button).BackColor = System.Drawing.Color.Black;
            }
            else 
            {
                myHouse.Walls[WallId].Openings[OpenId].isOpen = true;
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

            myHouse.Rooms[RoomId].hot_is_active = !myHouse.Rooms[RoomId].hot_is_active;
            Fire_panel.Visible = myHouse.Rooms[RoomId].hot_is_active;
            if (myHouse.Rooms[RoomId].hot_is_active)
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
            myHouse.Rooms[0].light_is_active = !myHouse.Rooms[0].light_is_active;
            lighActivePanel.Visible = myHouse.Rooms[0].light_is_active;
            if (myHouse.Rooms[0].light_is_active)
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
        /// force the temperature change with the view 
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
                    myHouse.Rooms[Convert.ToInt16((sender as TextBox).Tag)].temperature = Convert.ToDouble((sender as TextBox).Text);
                    // change in the view
                    changeTempView(Convert.ToInt16((sender as TextBox).Tag), (sender as TextBox).Text);
                }

            }
        }


        private void TMainRoutine_Tick(object sender, EventArgs e)
        {
            Boolean to_regul = false;

            //taking system state (door and windows)
            if (GlobalVariables.mode == "normal")
            {
                //checkstates by card
            }
            else
            {
                // check states on the view
            }

            // verification of change
            // if change=> to_regul à true

            // taking the temperature
            // 300 * 1 sec = 5 min
            if (routine_count >= 300)
            {
                if (GlobalVariables.mode == "normal")
                {
                    // check temp by card
                }
                else
                {
                    // check temp by calc
                }

                //if change => to_regul a true

                // resetting the routine counter
                routine_count = -1;
            }

            // regulation
            if (to_regul == true)
            {
                //regulation routine

                if (GlobalVariables.mode == "normal")
                {
                    // change to the card 
                }
                else
                {
                    // change into the view
                }
            }
            routine_count++;
        }

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

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
