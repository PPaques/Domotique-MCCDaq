using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;
using Excel = Microsoft.Office.Interop.Excel; 

namespace MyhouseDomotique
{
    class Export
    {

        /// <summary>
        /// Function that export data for only one room from the database to an Excel file.
        /// </summary>
        public static void ExportTempToExcel(Int32 IDRoom)
        {
            string Table;
            Table = "PK_id_autoIncrem" + "\t" + "FK_id_Room" + "\t" + "Time" + "\t" + "Temperature" + "\r\n";   // Each line contains time of measurement and the value of temperature (columns C & D)

            SqlCeCommand com = new SqlCeCommand("SELECT Temperature, Time FROM Temperatures_History WHERE FK_id_Room=" + IDRoom + " ORDER BY Time ASC ", GlobalVariables.conn);
            SqlCeDataReader reader = com.ExecuteReader();
            
            while (reader.Read())
            {
                string num = Convert.ToDouble(reader.GetValue(0)).ToString("g").Replace(",", ".");
                string num3 = Convert.ToDateTime(reader.GetValue(1)).ToString("dd/MM/yyyy hh:mm:ss");

                string ligne = "\t" + "\t" + num3 + "\t" + num + "\r\n";
                Table = Table + ligne;
            }
                

            //Send Table via the Clipboard
            Clipboard.SetDataObject(Table, true);

            //Excel elements
            Excel.Application oXL;  //Excel application object
            Excel.Workbook oWB;     //Workbook
            Excel.Worksheet oSheet; //Sheet
            Excel.Range oRng;       //Cell range
            oXL = new Excel.Application(); //Open Excel
            oXL.Visible = true;     //Show Excel

            //Obtain new a Workbook
            oWB = (Excel.Workbook)(oXL.Workbooks.Add(1));   //First Sheet
            oSheet = (Excel.Worksheet)oWB.ActiveSheet;
            oSheet.Name = GlobalVariables.MyHouse.Rooms[IDRoom].name;

            oRng = oSheet.get_Range("A1", "A1");        // Select first cell
            oSheet.Paste(oRng, false);                  // Copy/Paste

            // Adjust cells sizes
            oSheet.Rows.EntireRow.AutoFit();
            oSheet.Columns.EntireColumn.AutoFit();

            //Put columns C & D header in bold
            oRng = oSheet.get_Range("C1", "D1");
            oRng.Font.Bold = true;

            // Create a chart in (400,0) size = 500x400
            Excel.ChartObjects oCharts = (Excel.ChartObjects)oSheet.ChartObjects(Type.Missing);
            Excel.ChartObject oChartObj = oCharts.Add(400, 0, 500, 400);
            oChartObj.Chart.ChartType = Excel.XlChartType.xlLineMarkersStacked; //Chart type
            oChartObj.Name = "Graphe 1";

            //Select columns C & D to plot
            oRng = oSheet.get_Range("C:C", "D:D");

            //Values from columns C & D definied as datasource
            oChartObj.Chart.SetSourceData(oRng, Excel.XlRowCol.xlColumns);


            //Add a title for the chart
            oChartObj.Chart.ChartTitle.Text = "Températures en fonction du temps" + "\r (" + GlobalVariables.MyHouse.Rooms[IDRoom].name+")";
            
            //Add axis titles
            Excel.Axis x_axis = (Excel.Axis)oChartObj.Chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
            x_axis.HasTitle = true;
            x_axis.AxisTitle.Text = "Temps";
            Excel.Axis y_axis = (Excel.Axis)oChartObj.Chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
            y_axis.HasTitle = true;
            y_axis.AxisTitle.Text = "Températures (°C)";

            //Show value for each point in the chart
            oChartObj.Chart.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowValue, false, false, false, false, false, true, false, false, false);
        }

        /// <summary>
        /// Function that export all temperatures data from the data base to an Excel file.
        /// </summary>
        /// <param name="IDRoom"></param>
        /// <param name="Mode"></param>
        public static void ExportTempToExcelAll()
        {
            string[] Donnees = new string[4];
            string Table;

            for (int i = 0; i < 4; i++)
            {
                //Table's header
                Table = "Time" + "\t" + "Temperature" + "\r\n";
                using (SqlCeCommand com = new SqlCeCommand("SELECT Temperature, Time FROM Temperatures_History WHERE FK_id_Room=" + i + " ORDER BY Time ASC ", GlobalVariables.conn))
                {
                    SqlCeDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        string num = Convert.ToDouble(reader.GetValue(0)).ToString("g").Replace(",", ".");
                        string num3 = Convert.ToDateTime(reader.GetValue(1)).ToString("dd/MM/yyyy hh:mm:ss");

                        string ligne;
                        ligne = num3 + "\t" + num + "\r\n";
                        Table = Table + ligne;
                    }
                }
                Donnees[i] = Table;
            }
            
            //Excel elements
            Excel.Application oXL;  //Excel application object
            Excel.Workbook oWB;     //Workbook
            Excel.Worksheet oSheet; //Sheet
            Excel.Range oRng;       //Cell range
            oXL = new Excel.Application(); //Open Excel
            oXL.Visible = true;     //Show Excel

            //Obtain new a Workbook
            oWB = (Excel.Workbook)(oXL.Workbooks.Add(1));   //First Sheet
            oSheet = (Excel.Worksheet)oWB.Worksheets.Add(Type.Missing, (Excel.Worksheet)oWB.ActiveSheet, 3, Type.Missing);  //Add 3 sheets to the Workbook

            //Send the table in the clipboard
            for (int j = 0; j < 4; j++)
            {
                Clipboard.SetDataObject(Donnees[j], true);
                oSheet = (Excel.Worksheet)oXL.Worksheets["Sheet" + (j + 1)];
                oSheet.Select(true);
                oSheet.Name = GlobalVariables.MyHouse.Rooms[j].name;
           
                oRng = oSheet.get_Range("A1", "A1");        // Select first cell
                oSheet.Paste(oRng, false);                  // Copy/Paste

                //Adjust cells sizes
                oSheet.Rows.EntireRow.AutoFit();
                oSheet.Columns.EntireColumn.AutoFit();

                //Put columns C & D header in bold
                oRng = oSheet.get_Range("A1", "B1");
                oRng.Font.Bold = true;

                //Create a chart in (400,0) size = 500x400
                Excel.ChartObjects oCharts = (Excel.ChartObjects)oSheet.ChartObjects(Type.Missing);
                Excel.ChartObject oChartObj = oCharts.Add(400, 0, 500, 400);
                oChartObj.Chart.ChartType = Excel.XlChartType.xlLineMarkersStacked; //Chart type.
                oChartObj.Name = "Graphe 1";

                //Select columns A & B to plot
                oRng = oSheet.get_Range("A:A", "B:B");
                oSheet.get_Range("B:B").NumberFormat = "General";

                //Values from columns A & B definied as datasource
                oChartObj.Chart.SetSourceData(oRng, Excel.XlRowCol.xlColumns);

                //Add a title for the chart
                oChartObj.Chart.ChartTitle.Text = "Températures en fonction du temps" + "\r (" + GlobalVariables.MyHouse.Rooms[j].name+")";

                //Add titles to axis
                Excel.Axis x_axis = (Excel.Axis)oChartObj.Chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
                x_axis.HasTitle = true;
                x_axis.AxisTitle.Text = "Temps";
                Excel.Axis y_axis = (Excel.Axis)oChartObj.Chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
                y_axis.HasTitle = true;
                y_axis.AxisTitle.Text = "Températures (°C)";

                //Show value for each point in the chart
                oChartObj.Chart.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowValue, false, false, false, false, false, true, false, false, false);
            }
        }


        /// <summary>
        /// Exporting states to excel
        /// </summary>
        /// <param name="IDRoom"></param>
        public static void ExportStatesToExcel(Int32 IDRoom)
        {

            string Table1;
            Table1 = "PK_id_autoIncrem" + "\t" + "FK_id_Wall" + "\t" + "FK_id_Opening" + "\t" + "Time" + "\t" + "New_State" + "\r\n";

            // On construit la requête pour ensuite lire les valeurs du reader
            Int32 FK_id_Wall1 = 0;
            Int32 FK_id_Wall2 = 0;
            Int32 FK_id_Wall3 = 0;

            //Selection id Wall
            switch (IDRoom)
            {
                case 1:
                    FK_id_Wall1 = 0;
                    FK_id_Wall2 = 3;
                    FK_id_Wall3 = 4;
                    break;

                case 2:
                    FK_id_Wall1 = 1;
                    FK_id_Wall2 = 3;
                    FK_id_Wall3 = 5;
                    break;

                case 3:
                    FK_id_Wall1 = 2;
                    FK_id_Wall2 = 4;
                    FK_id_Wall3 = 5;
                    break;
            }

            SqlCeCommand com = new SqlCeCommand("SELECT FK_id_Wall, FK_id_Opening,Time, New_State FROM States_History WHERE FK_id_Wall=" + FK_id_Wall1 + " OR FK_id_Wall=" + FK_id_Wall2 + " OR FK_id_Wall=" + FK_id_Wall3 + "ORDER BY Time ASC ", GlobalVariables.conn);
            SqlCeDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string num = Convert.ToString(reader.GetValue(0));
                string num11 = Convert.ToString(reader.GetValue(1));
                string num3 =  Convert.ToDateTime(reader.GetValue(2)).ToString("dd/MM/yyyy hh:mm:ss");
                string num22 = Convert.ToString(reader.GetValue(3));

                //MessageBox.Show("Valeur : " + num + "°C à la date du " + num1);
                string ligne;
                ligne = "\t" + num + "\t" + num11 + "\t" + num3 + "\t" + num22 + "\r\n";
                Table1 = Table1 + ligne;
            }
        
            // envoi du tableau dans le presse-papiers
            Clipboard.SetDataObject(Table1, true);

            // Eléments d'EXCEL
            Excel.Application oXL;  // Objet Excel application
            Excel.Workbook oWB;     // Classeur
            Excel.Worksheet oSheet; // Feuille
            Excel.Range oRng;       // Cellules
            oXL = new Excel.Application(); // OUVERTURE D'EXCEL
            oXL.Visible = true;     // excel visible

            //Obtenir un nouveau classeur
            oWB = (Excel.Workbook)(oXL.Workbooks.Add(1));
            oSheet = (Excel.Worksheet)oWB.ActiveSheet;  // et la 1ère feuille
            oSheet.Name = GlobalVariables.MyHouse.Rooms[IDRoom].name;
            
            oRng = oSheet.get_Range("A1", "A1");        // sélection première cellule
            oSheet.Paste(oRng, false);                  // Copier-Coller

            // ajuster les largeurs et hauteurs des cellules
            oSheet.Rows.EntireRow.AutoFit();
            oSheet.Columns.EntireColumn.AutoFit();

            //oSheet.Columns.AutoFit();
            oRng = oSheet.get_Range("A1", "B1");    // sélection première ligne
            oRng.Font.Bold = true;                  // et passage en GRAS

            // création d'un graphique en 150,0,500,400 point supérieur et largeur en pixels
            Excel.ChartObjects oCharts = (Excel.ChartObjects)oSheet.ChartObjects(Type.Missing);
            Excel.ChartObject oChartObj = oCharts.Add(400, 0, 500, 400);
            oChartObj.Name = "Graphe 1";

            // on prend toutes les cellules actives
            oRng = oSheet.UsedRange.Cells;

            // et on les met comme base du dessin
            oChartObj.Chart.SetSourceData(oRng, Excel.XlRowCol.xlColumns);
            oChartObj.Chart.ChartType = Excel.XlChartType.xl3DColumnStacked;
        }


        /// <summary>
        /// Export all states to a xls
        /// </summary>
        public static void ExportStatesToExcelAll()
        {
            string[] Donnees = { "0", "0", "0" };
            string Table;

            for (int i = 1; i <= 3; i++)
            {
                Table = "PK_id_autoIncrem" + "\t" + "FK_id_Wall" + "\t" + "FK_id_Opening" + "\t" + "Time" + "\t" + "New_State" + "\r\n";
         
                string sql_command = null;
                switch (i)
                {
                    case 1:
                        sql_command = "SELECT FK_id_Wall, FK_id_Opening,Time, New_State FROM States_History WHERE FK_id_Wall=0 OR FK_id_Wall=3 OR FK_id_Wall=4 ORDER BY Time ASC ";
                        break;

                    case 2:
                        sql_command = "SELECT FK_id_Wall, FK_id_Opening,Time, New_State FROM States_History WHERE FK_id_Wall=1 OR FK_id_Wall=3 OR FK_id_Wall=5 ORDER BY Time ASC ";
                        break;

                    case 3:
                        sql_command = "SELECT FK_id_Wall, FK_id_Opening, Time, New_State FROM States_History WHERE FK_id_Wall=2 OR FK_id_Wall=4 OR FK_id_Wall=5 ORDER BY Time ASC ";
                        break;
                }

                SqlCeCommand com = new SqlCeCommand(sql_command, GlobalVariables.conn);
                SqlCeDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string num = Convert.ToString(reader.GetValue(0));
                    string num11 = Convert.ToString(reader.GetValue(1));
                    string num3 =  Convert.ToDateTime(reader.GetValue(2)).ToString("dd/MM/yyyy hh:mm:ss");
                    string num22 = Convert.ToString(reader.GetValue(3));

                    //MessageBox.Show("Valeur : " + num + "°C à la date du " + num1);
                    string ligne;
                    ligne = "\t" + num + "\t" + num11 + "\t" + num3 + "\t" + num22 + "\r\n";
                    Table = Table + ligne;

                 }
                 
                Donnees[i - 1] = Table;

            }


            // Eléments d'EXCEL
            Excel.Application oXL;  // Objet Excel application
            Excel.Workbook oWB;     // Classeur
            Excel.Worksheet oSheet; // Feuille
            Excel.Range oRng;       // Cellules
            oXL = new Excel.Application(); // OUVERTURE D'EXCEL
            oXL.Visible = true;     // excel visible

            //Obtenir un nouveau classeur
            oWB = (Excel.Workbook)(oXL.Workbooks.Add(1));
            //oSheet = (Excel.Worksheet)oWB.ActiveSheet;  // et la 1ère feuille
            //oSheet = (Excel.Worksheet)(oWB.Sheets.Add(1));
            oSheet = (Excel.Worksheet)oWB.Worksheets.Add(Type.Missing, (Excel.Worksheet)oWB.ActiveSheet, 2, Type.Missing);

            // envoi du tableau dans le presse-papiers
            for (int j = 1; j <= 3; j++)
            {
                Clipboard.SetDataObject(Donnees[j - 1], true);

                oSheet = (Excel.Worksheet)oXL.Worksheets["Sheet" + j];
                oSheet.Select(true);
                oSheet.Name = GlobalVariables.MyHouse.Rooms[j].name;
             
                oRng = oSheet.get_Range("A1", "A1");        // sélection première cellule
                oSheet.Paste(oRng, false);                  // Copier-Coller

                // ajuster les largeurs et hauteurs des cellules
                oSheet.Rows.EntireRow.AutoFit();
                oSheet.Columns.EntireColumn.AutoFit();

                //oSheet.Columns.AutoFit();
                oRng = oSheet.get_Range("A1", "B1");    // sélection première ligne
                oRng.Font.Bold = true;                  // et passage en GRAS

                // création d'un graphique en 150,0,500,400 point supérieur et largeur en pixels
                Excel.ChartObjects oCharts = (Excel.ChartObjects)oSheet.ChartObjects(Type.Missing);
                Excel.ChartObject oChartObj = oCharts.Add(400, 0, 500, 400);
                oChartObj.Name = "Graphe 1";

                // on prend toutes les cellules actives
                oRng = oSheet.UsedRange.Cells;

                // et on les met comme base du dessin
                oChartObj.Chart.SetSourceData(oRng, Excel.XlRowCol.xlColumns);
                oChartObj.Chart.ChartType = Excel.XlChartType.xl3DColumnStacked;
            }
        }
    }
}
