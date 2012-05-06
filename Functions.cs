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
                    ProgressBar = Program.MainForm.ProgressBarOutdoor;
                    Tbtemp = Program.MainForm.tBOutdoorTempAct;
                    break;
                case 1:
                    ProgressBar = Program.MainForm.ProgressBarSaloon;
                    Tbtemp = Program.MainForm.tBSaloonTempAct;
                    break;
                case 2:
                    ProgressBar = Program.MainForm.ProgressBarKitchen;
                    Tbtemp = Program.MainForm.tBKitchenTempAct;
                    break;
                case 3:
                    ProgressBar = Program.MainForm.ProgressBarBedRoom;
                    Tbtemp = Program.MainForm.tBBedRoomTempAct;
                    break;
                default:
                    MessageBox.Show("Error at Change Hot State (Room ID out of range)");
                    break;
            }

            if (value < min)
            {
                Tbtemp.Text = "LO";
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
        
    }
}

