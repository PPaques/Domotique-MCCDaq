using System;
using System.Windows.Forms;

namespace MyhouseDomotique
{
    class Functions : Object
    {
        public static bool ContentsVerification(string TestTemp)
        {
            try
            {
                if (Convert.ToDouble(TestTemp) > 60 || Convert.ToDouble(TestTemp) < 10)
                {
                    MessageBox.Show("Attention " + TestTemp + "°C n'est pas compris entre 10 et 60°C", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}

