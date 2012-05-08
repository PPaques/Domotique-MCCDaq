using System;
using System.Windows.Forms;

namespace MyhouseDomotique
{
    class Functions : Object
    {
        /// <summary>
        /// Function that verify if temp is between min and max range
        /// </summary>
        /// <param name="TestTemp"></param>
        /// <returns></returns>
        public static Boolean TemperatureRange(string TestTemp, double min, double max)
        {
            try
            {
                if (Convert.ToDouble(TestTemp) < min || Convert.ToDouble(TestTemp) > max)
                {
                    MessageBox.Show("Attention " + TestTemp + "°C n'est pas compris entre " + Convert.ToDouble(min) + " et " + Convert.ToDouble(max) + "°C", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Hé non, " + TestTemp + " n'est pas une valeur valide!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        /// <summary>
        /// Function that convert to double with the good coma system
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string ConvertSeparator(string Value)
        {
            if (Value.Contains(".") || Value.Contains(","))
            {
                Value = Value.Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator)
                             .Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            }
            return Value;
        }

        /// <summary>
        /// Function that convert open or close to a boolean
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Boolean isOpenCheck(string Value)
        {
            if (Value == "open")
                return true;
            else
                return false;
        }

        /// <summary>
        /// Convert a boolean to a open or close string
        /// </summary>
        public static void IsOpenToView(Button ButtonToChange, Boolean IsOpen )
        {
            if (IsOpen) {
                ButtonToChange.Tag = "open";
                ButtonToChange.BackColor = System.Drawing.Color.Maroon;
            }
            else {
                ButtonToChange.Tag = "close";
                ButtonToChange.BackColor = System.Drawing.Color.Black;
            }
        }

        /// <summary>
        /// changing the temperature with the textbox and progressbar
        /// </summary>
        /// <param name="RoomId"></param>
        /// <param name="Value"></param>
        public static void changeTempView(int RoomId, string getValue)
        {
            double value = GlobalVariables.MinTemp;

            if (getValue == "HI")
            {
                value = GlobalVariables.MaxTemp;
            }
            else
            {
                value = Convert.ToDouble(getValue);
            }

            VertcicalProgressBar ProgressBar = selectVerticalProgress(RoomId);
            TextBox Tbtemp = selectTbTempActual(RoomId);

            if (value < GlobalVariables.MinTemp)
            {
                Tbtemp.Text = "LO";
                ProgressBar.Value = 0;
            }
            else if (value > GlobalVariables.MaxTemp)
            {
                Tbtemp.Text = "HI";
                ProgressBar.Value = 100;
            }
            else
            {
                Tbtemp.Text = Convert.ToString(getValue);
                ProgressBar.Value = Convert.ToInt16(((value - GlobalVariables.MinTemp) / (GlobalVariables.MaxTemp - GlobalVariables.MinTemp)) * 100);
            }
        }


        // *-------------------------------------------------------------*
        // *   functions to select good élements in the view             *
        // *-------------------------------------------------------------*
        /// <summary>
        /// Function that select the good hotpanel with the roomid
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public static FireHotPannel selectPannelHot(int RoomId)
        {
            FireHotPannel Hotpanel =null;

            switch (RoomId)
            {
                case 1:
                    Hotpanel = Program.MainForm.fireHotSaloon;
                    break;
                case 2:
                    Hotpanel = Program.MainForm.fireHotKitchen;
                    break;
                case 3:
                    Hotpanel = Program.MainForm.fireHotBedRoom;
                    break;
                default:
                    MessageBox.Show("Error at selecting view hotpannel (Room ID out of range)");
                    break;
            }

            return Hotpanel;
        }

        /// <summary>
        /// function that select the good cold pannel with the roomid
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public static FireColdPannel selectPannelCold(int RoomId)
        {
            FireColdPannel Coldpanel = null;

            switch (RoomId)
            {
                case 1:
                    Coldpanel = Program.MainForm.fireColdSaloon;
                    break;
                case 2:
                    Coldpanel = Program.MainForm.fireColdKitchen;
                    break;
                case 3:
                    Coldpanel = Program.MainForm.fireColdPannelBedRoom;
                    break;
                default:
                    MessageBox.Show("Error at selecting view cold (Room ID out of range)");
                    break;
            }

            return Coldpanel;
        }

        /// <summary>
        /// selecting the good verticalprogressbar with the roomid
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public static VertcicalProgressBar selectVerticalProgress(int RoomId)
        {
            VertcicalProgressBar VerticalProgress = null;
            
            switch (RoomId)
            {
                case 0:
                    VerticalProgress = Program.MainForm.ProgressBarOutdoor;
                    break;
                case 1:
                    VerticalProgress = Program.MainForm.ProgressBarSaloon;
                    break;
                case 2:
                    VerticalProgress = Program.MainForm.ProgressBarKitchen;
                    break;
                case 3:
                    VerticalProgress = Program.MainForm.ProgressBarBedRoom;
                    break;
                default:
                    MessageBox.Show("Error at select progressbarvertical (Room ID out of range)");
                    break;
            }

            return VerticalProgress;
        }
        
        /// <summary>
        /// selecting the good textbox with the roomid
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public static TextBox selectTbTempActual(int RoomId)
        {
            TextBox Textbox = null;

            switch (RoomId)
            {
                case 0:
                    Textbox = Program.MainForm.tBOutdoorTempAct;
                    break;
                case 1:
                    Textbox = Program.MainForm.tBSaloonTempAct;
                    break;
                case 2:
                    Textbox = Program.MainForm.tBKitchenTempAct;
                    break;
                case 3:
                    Textbox = Program.MainForm.tBBedRoomTempAct;
                    break;
                default:
                    MessageBox.Show("Error at select the good actual temp textbox (Room ID out of range)");
                    break;
            }
            return Textbox;
        }

        /// <summary>
        /// Selecting the good temp order textbox
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public static TextBox selectTbTempOrder(int RoomId)
        {
            TextBox Textbox = null;

            switch (RoomId)
            {
                case 1:
                    Textbox = Program.MainForm.tBSaloonTempRef;
                    break;
                case 2:
                    Textbox = Program.MainForm.tBKitchenTempRef;
                    break;
                case 3:
                    Textbox = Program.MainForm.tBBedRoomTempRef;
                    break;
                default:
                    MessageBox.Show("Error at select the good actual temp ref textbox (Room ID out of range)");
                    break;
            }
            return Textbox;
        }
    
    }
}

