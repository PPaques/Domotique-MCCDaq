using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace MyhouseDomotique
{
    /// <summary>
    /// A class that stock all the global variables
    /// </summary>
    public static class GlobalVariables
    {
        // list of global variables
        public static string mode { get; set; }
        public static House MyHouse { get; set; }
        public static SqlCeConnection conn { get; set; }
        public static double MinTemp { get; set; }
        public static double MaxTemp { get; set; }
        public static Boolean godMode { get; set; }
        public static Boolean LightAutomatique { get; set; }
    }
}
