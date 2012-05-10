using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;

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


        // *-------------------------------------------------------------*
        // *   Functions to change something in the view                 *
        // *-------------------------------------------------------------*
        /// <summary>
        /// changing the temperature with the textbox and progressbar
        /// </summary>
        /// <param name="RoomId"></param>
        /// <param name="Value"></param>
        public static void SetTempView(int RoomId, string getValue)
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

        /// <summary>
        /// Function to set the hot state
        /// </summary>
        /// <param name="RoomId"></param>
        public static void SetHotStateView(int RoomId)
        {
            if (GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active)
            {
                selectbtnHot(RoomId).Text = "On";
                Functions.selectPannelHot(RoomId).Visible = true;
                Functions.selectPannelCold(RoomId).Visible = false;
            }
            else
            {
                selectbtnHot(RoomId).Text = "Off";
                Functions.selectPannelHot(RoomId).Visible = false;
                Functions.selectPannelCold(RoomId).Visible = true;
            }

        }

        /// <summary>
        /// Set light state into the view
        /// </summary>
        public static void SetLightState()
        {
            if (GlobalVariables.MyHouse.Rooms[0].light_is_active)
            {
                Program.MainForm.BtOutdoorLight.Text = "On";
                Program.MainForm.lighActivePanel.Visible = true;
                Program.MainForm.lighInactivePanel.Visible = false;
            }
            else
            {
                Program.MainForm.BtOutdoorLight.Text = "Off";
                Program.MainForm.lighActivePanel.Visible = false;
                Program.MainForm.lighInactivePanel.Visible = true;
            }
        }

        // *-------------------------------------------------------------*
        // *   functions to select good elements in the view             *
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

        /// <summary>
        /// selecting the good btn hot with the roomid
        /// </summary>
        /// <param name="RoomId"></param>
        /// <returns></returns>
        public static Button selectbtnHot(int RoomId)
        {
            Button btn = null;

            switch (RoomId)
            {
                case 1:
                    btn = Program.MainForm.BtSaloonHot;
                    break;
                case 2:
                    btn = Program.MainForm.BtKitchenHot;
                    break;
                case 3:
                    btn = Program.MainForm.BtBedRoomHot;
                    break;
                default:
                    MessageBox.Show("Error at select the good btn hot textbox (Room ID out of range)");
                    break;
            }
            return btn;     
        }


        // *-------------------------------------------------------------*
        // *                 Database functions                          *
        // *-------------------------------------------------------------*
        /// <summary>
        /// On donne à la fonction l'ID de la pièce dont on veut les températures 
        /// </summary>
        /// <param name="FK_id_Room"></param>
        public static SqlCeDataReader ReadTemperatureFromDataBase(Int32 FK_id_Room, Int32 limit)    
        {
         
            // On construit la requête pour ensuite lire les valeurs du reader
            SqlCeCommand com = new SqlCeCommand("SELECT Temperature, Time FROM Temperatures_History WHERE FK_id_Room=" + FK_id_Room + " ORDER BY Time ASC LIMIT " + limit, GlobalVariables.conn);
            SqlCeDataReader reader = com.ExecuteReader();
            return reader;
            /*while (reader.Read())
            {
              string num = Convert.ToString(reader.GetValue(0));
              string num1 = Convert.ToString(reader.GetValue(1));
              MessageBox.Show("Valeur : " + num + "°C à la date du " + num1);
            }*/
        }
        
        /// <summary>
        /// On donne à la fonction l'ID de la pièce avec laquelle on travaille and the temperature
        /// </summary>
        /// <param name="IDRoom"></param>
        /// <param name="Temperature"></param>
        public static void SaveTemperature(Int32 IDRoom, double Temperature)      // On donne à la fonction l'ID de la pièce avec laquelle on travaille, sa température et ensuite le mode dans lequel on est (mode "simulation" ou "normal")
        {
            // On stocke dans les classes
            GlobalVariables.MyHouse.Rooms[IDRoom].temperature = Temperature;
            
            // Stockage en base de donnée
            // Vérification de la dernière température stockée
            double LastTemp = 0;

           SqlCeCommand cn = new SqlCeCommand("SELECT Temperature, Time FROM Temperatures_History WHERE FK_id_Room=" + IDRoom + " ORDER BY Time DESC LiMit1", GlobalVariables.conn);
           SqlCeDataReader reader = cn.ExecuteReader();
           LastTemp = Convert.ToDouble(reader.GetValue(0));
           
            if ((LastTemp - Temperature < 0.2) || (LastTemp + Temperature > 0.2))
            {
                //On récupère les variables/on convertit
                DateTime time = DateTime.Now;
                //Conversion du double Temperature en float
                float temperature = (float)Temperature;
    
                //On définit la commande SQL
                SqlCeCommand cmd;

                //On crée la requête
                string sql = "insert into Temperatures_History "
                + "( FK_id_Room, Time, Temperature) "
                + "values (@idroom, @time, @temperature)";

                //On exécute la requête
                try
                {
                    cmd = new SqlCeCommand(sql, GlobalVariables.conn);
                    cmd.Parameters.AddWithValue("@idroom", IDRoom);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@temperature", temperature);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue lors de l'écriture dans la base de donnée");
                }
            }
        }

        /// <summary>
        /// reading states from database
        /// </summary>
        /// <param name="IDWall"></param>
        /// <param name="Mode"></param>
        public static SqlCeDataReader ReadStateFromDataBase(Int32 IDWall, string Mode, Int32 Limit)      // On donne à la fonction l'ID du mur dont on veut l'état et ensuite le mode à lire (mode "simulation" ou "normal")
        {
            // On construit la requête pour ensuite lire les valeurs du reader
            Int32 FK_id_Wall = IDWall;
            SqlCeCommand com = new SqlCeCommand("SELECT New_state, Time FROM States_History WHERE FK_id_Wall=" + FK_id_Wall + " ORDER BY Time ASC LIMIT "+Limit , GlobalVariables.conn);
            SqlCeDataReader reader = com.ExecuteReader();
            /*while (reader.Read())
            {
                string num = Convert.ToString(reader.GetValue(0));
                string num1 = Convert.ToString(reader.GetValue(1));
                MessageBox.Show("Etat : " + num + " à la date du " + num1);
            }*/
            return reader;
        }
        
        /// <summary>
        /// SaveStatesTodatabase
        /// </summary>
        /// <param name="IDWall"></param>
        /// <param name="State"></param>
        public static void SaveStatesToDataBase(Int32 IDWall,Int32 IDOpening, bool State)      // On donne à la fonction l'ID du mur avec lequel on travaille, son état et ensuite le mode dans lequel on est (mode "simulation" ou "normal")
        {
            Boolean oldState = GlobalVariables.MyHouse.Walls[IDWall].Openings[IDOpening].isOpen;

            if (State != oldState)
            {
                GlobalVariables.MyHouse.Walls[IDWall].Openings[IDOpening].isOpen = State;
                //On récupère les variables/on convertit
                DateTime time = DateTime.Now;
                Byte state = Convert.ToByte(State);

                //On définit la commande SQL
                SqlCeCommand cmd;

                //On crée la requête
                string sql = "insert into States_History "
                + "( FK_id_Wall, Time, New_State) "
                + "values (@idwall, @time, @state)";

                //On exécute la requête
                try
                {
                    cmd = new SqlCeCommand(sql, GlobalVariables.conn);
                    cmd.Parameters.AddWithValue("@idwall", IDWall);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue lors de l'écriture dans la base de donnée");
                }
            }
        }

    
    }
}

