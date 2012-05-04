using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyhouseDomotique
{
    class TimerFunctions
    {
        /// <summary>
        /// Function that perform the regulation, ON the hot when it's need
        /// </summary>
        public static void regulation()
        {
            // Kitchen
            if ((GlobalVariables.MyHouse.Rooms[2].temperature) < (GlobalVariables.MyHouse.Rooms[2].temperature_order) && (GlobalVariables.MyHouse.Walls[1].Openings[0].isOpen==false))
            {
                if ((GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen==false) || ((GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen==false) && (GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen==false) && (GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen==false) && (GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen==false)) || ((GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen==false) && (GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen==false) && (GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen==false) && (GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen==false)))
                {
                    Program.MainForm.fireHotKitchen.Visible = true;
                    Program.MainForm.fireColdKitchen.Visible = false;
                }
                else
                {
                    Program.MainForm.fireHotKitchen.Visible = false;
                    Program.MainForm.fireColdKitchen.Visible = true;
                }
            }
            else
            {
                Program.MainForm.fireHotKitchen.Visible = false;
                Program.MainForm.fireColdKitchen.Visible = true;
            }


            // bedroom
            if ((GlobalVariables.MyHouse.Rooms[3].temperature) < (GlobalVariables.MyHouse.Rooms[3].temperature_order) && (GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen == false))
            {
                if (((GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen == false)) || ((GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen == false) && (GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen == false)) || ((GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen == false) && (GlobalVariables.MyHouse.Walls[1].Openings[0].isOpen == false)))
                {
                    Program.MainForm.fireHotBedRoom.Visible = true;
                    Program.MainForm.fireColdPannelBedRoom.Visible = false;
                }
                else
                {
                    Program.MainForm.fireHotBedRoom.Visible = false;
                    Program.MainForm.fireColdPannelBedRoom.Visible = true;
                }
            }
            else
            {
                Program.MainForm.fireHotBedRoom.Visible = false;
                Program.MainForm.fireColdPannelBedRoom.Visible = true;
            }

            //salon
            if ((GlobalVariables.MyHouse.Rooms[1].temperature) < (GlobalVariables.MyHouse.Rooms[1].temperature_order) && (GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen == false))
            {
                if (((GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen == false) && (GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen == false)) || ((GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen == false) && (GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen == false)) || ((GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen == false) && (GlobalVariables.MyHouse.Walls[1].Openings[0].isOpen == false)))
                {
                    Program.MainForm.fireHotSaloon.Visible = true;
                    Program.MainForm.fireColdSaloon.Visible = false;
                }
                else
                {
                    Program.MainForm.fireHotSaloon.Visible = false;
                    Program.MainForm.fireColdSaloon.Visible = true;
                }
            }
            else
            {
                Program.MainForm.fireHotSaloon.Visible = false;
                Program.MainForm.fireColdSaloon.Visible = true;
            }
        }
    }
}
