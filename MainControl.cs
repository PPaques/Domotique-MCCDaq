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
            MessageBox.Show("wooo");
            StatusBarMode.Text = "Mode "+ GlobalVariables.mode;
            
            // creating the house
            myHouse = new House();

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


    }
}
