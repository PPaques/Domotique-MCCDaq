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
        public static double ConvertToDoubleSeparator(string Value)
        {
            if (Value.Contains(".") || Value.Contains(","))
            {
                Value = Value.Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator)
                             .Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            }
            return Convert.ToDouble(Value);
        }
        
    }
}

