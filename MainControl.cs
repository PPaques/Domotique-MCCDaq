using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyhouseDomotique
{

    public partial class MainControl : Form
    {
        // global variables
        SqlCeConnection conn = null;
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

            // connection to the db
            if (GlobalVariables.mode == "normal")
            {
                conn = new SqlCeConnection("Data Source = |DataDirectory|normal.sdf");
            }
            else 
            {
                conn = new SqlCeConnection("Data Source = |DataDirectory|simulation.sdf");        
            }
            conn.Open();
        }

        /// <summary>
        /// When we close the main window, we have to shut down the database link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit(object sender, FormClosingEventArgs e)
        {
            // Closing connection
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

    }
}
