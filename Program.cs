using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyhouseDomotique
{
    public static class Program
    {
        public static MainControl MainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainControl();
            Application.Run(MainForm);
        }
    }
}
