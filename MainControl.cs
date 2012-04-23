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
        /// Initialising the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Initialisation(object sender, EventArgs e)
        {
            // verifying and setting the card
            MyCard = new Card();
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
            if (myHouse.Rooms[RoomId].hot_is_active)
            {
                (sender as Button).Text = "On";
                Fire_panel.Visible = true;
            }
            else
            {
                (sender as Button).Text = "Off";
                Fire_panel.Visible = false;
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




    }
}
