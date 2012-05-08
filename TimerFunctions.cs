using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyhouseDomotique
{
    class TimerFunctions
    {
        // *-----------------------------------------------------*
        // *       Regulation (check if we need to hot)          *
        // *-----------------------------------------------------*

        /// <summary>
        /// Function that perform the regulation, ON the hot when it's need
        /// </summary>
        public static void regulation()
        {
            // Kitchen
            if ((GlobalVariables.MyHouse.Rooms[2].temperature) < (GlobalVariables.MyHouse.Rooms[2].temperature_order) && (GlobalVariables.MyHouse.Walls[1].Openings[0].isOpen == false))
            {
                if ((GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen == false) || ((GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen == false) && (GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen == false)) || ((GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen == false) && (GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen == false) && (GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen == false)))
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

        // *-----------------------------------------------------*
        // *       Temperature on simulation calculating         *
        // *-----------------------------------------------------*
        /// <summary>
        /// Function that uses the forward states to find the new temperatures.
        /// </summary>
        public static void calculate_next_temp()
        {
            //Création des variables
            double[] NewTemp = new double[] { 1024, 1024, 1024, 1024 };           // On crée un vecteur qui contiendra les températures calculées

            double TIteration = 1;		                        // Interval de calcul de température (on calcule toute les secondes)
            double P = 50;		                        // Puissance de la lampe dégagée.

            double SpecificHeatCap_Air = 1004;
            double AirDensity = 1.2;				    // en kg/m3 à 20 °C


            // Vérification si ouverture vers l'extérieur températures en découlants
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j < GlobalVariables.MyHouse.Walls[i].Openings.Count; j++)       // On regarde en tenant compte que une pièce peut avoir plusieurs ouvertures
                {
                    if (GlobalVariables.MyHouse.Walls[i].Openings[j].isOpen)
                    {
                        NewTemp[i + 1] = GlobalVariables.MyHouse.Rooms[0].temperature;      // On met dans le vecteur la température externe pour la pièce en contact avec l'extérieur (ID = i+1)
                    }
                }
            }

            // Vérification ouvertures internes et propagation des températures externes
            for (int i = 3; i <= 4; i++)
            {
                if (GlobalVariables.MyHouse.Walls[i].Openings[0].isOpen)
                {
                    if (NewTemp[GlobalVariables.MyHouse.Walls[i].Room1.IDRoom] != 1024 || NewTemp[GlobalVariables.MyHouse.Walls[i].Room2.IDRoom] != 1024)   // On regarde si une valeur existe déjà pour une des 2 pièces (ou les 2)
                    {
                        NewTemp[GlobalVariables.MyHouse.Walls[i].Room1.IDRoom] = GlobalVariables.MyHouse.Rooms[0].temperature;        // Les deux pièces sont à température externe
                        NewTemp[GlobalVariables.MyHouse.Walls[i].Room2.IDRoom] = GlobalVariables.MyHouse.Rooms[0].temperature;

                        if (i == 4 & GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen)   // changer pour la cuisine si ouvert dans la chambre
                        {
                            NewTemp[2] = GlobalVariables.MyHouse.Rooms[0].temperature;
                        }
                    }
                }
            }

            // Calculer la moyenne des températures si pièces en contact
            if (NewTemp[1] == 1024)     // On regarde si le salon n'est pas en contact avec l'extérieur (Temp == null)  car il est relié aux deux autres pièces.
            {
                if (GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen ^ GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen)      // Une ouverture ou (xor) l'autre est ouverte
                {
                    if (GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen)
                    {
                        double FinalTemp = ConnectedRooms(GlobalVariables.MyHouse.Rooms[1].temperature, GlobalVariables.MyHouse.Rooms[2].temperature, 0, GlobalVariables.MyHouse.Rooms[1].volume, GlobalVariables.MyHouse.Rooms[2].volume, 0);
                        NewTemp[1] = FinalTemp;
                        NewTemp[2] = FinalTemp;
                    }
                    else
                    {
                        double FinalTemp = ConnectedRooms(GlobalVariables.MyHouse.Rooms[1].temperature, GlobalVariables.MyHouse.Rooms[3].temperature, 0, GlobalVariables.MyHouse.Rooms[1].volume, GlobalVariables.MyHouse.Rooms[3].volume, 0);
                        NewTemp[1] = FinalTemp;
                        NewTemp[3] = FinalTemp;
                    }
                }
                if (GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen & GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen)       // Les deux ouvertures sont ouvertes
                {
                    double FinalTemp = ConnectedRooms(GlobalVariables.MyHouse.Rooms[1].temperature, GlobalVariables.MyHouse.Rooms[2].temperature, GlobalVariables.MyHouse.Rooms[3].temperature, GlobalVariables.MyHouse.Rooms[1].volume, GlobalVariables.MyHouse.Rooms[2].volume, GlobalVariables.MyHouse.Rooms[3].volume);
                    NewTemp[1] = FinalTemp;
                    NewTemp[2] = FinalTemp;
                    NewTemp[3] = FinalTemp;
                }
            }

            // On rempli par la température précédente les pièces où la température est encore null.
            for (int i = 1; i <= 3; i++)
            {
                if (NewTemp[i] == 1024)
                {
                    NewTemp[i] = GlobalVariables.MyHouse.Rooms[i].temperature;
                }
            }

            // Calculer transfers de température par les mur (positifs ou négatifs)
            for (int i = 1; i <= 3; i++)
            {
                NewTemp[i] = GlobalVariables.MyHouse.Rooms[0].temperature + ((NewTemp[i] - GlobalVariables.MyHouse.Rooms[0].temperature) / (Math.Exp(TIteration / GlobalVariables.MyHouse.Rooms[i].t0)));
            }


            // Calculer le chauffage
            for (int i = 1; i <= 3; i++)
            {
                if (GlobalVariables.MyHouse.Rooms[i].hot_is_active)    // On calcul l'apport de température si on chauffe (hot_is_active == true)
                {
                    NewTemp[i] = NewTemp[i] + (P / (AirDensity * GlobalVariables.MyHouse.Rooms[i].volume * SpecificHeatCap_Air * TIteration));
                }
            }

            // Inscription des nouvelles valeurs dans le modèle général
            for (int i = 1; i <= 3; i++)
            {
                GlobalVariables.MyHouse.Rooms[i].temperature = NewTemp[i];
            }
        }

        /// <summary>
        /// Function that calculate the connected room
        /// </summary>
        /// <param name="Temp1"></param>
        /// <param name="Temp2"></param>
        /// <param name="Temp3"></param>
        /// <param name="Vol1"></param>
        /// <param name="Vol2"></param>
        /// <param name="Vol3"></param>
        /// <returns></returns>
        private static double ConnectedRooms(double Temp1, double Temp2, double Temp3, double Vol1, double Vol2, double Vol3)       // Calcule la moyenne de température lors de l'ouverture d'une porte interne
        {
            double FinalTemp = ((2000 * Vol1 * Temp1) + (2000 * Vol2 * Temp2) + (2000 * Vol3 * Temp3)) / ((2000 * Vol1) + (2000 * Vol2) + (2000 * Vol3));
            return FinalTemp;
        }

        // *-----------------------------------------------------*
        // *      Interation between model and view              *
        // *-----------------------------------------------------*
        /// <summary>
        /// Taking all the states from View and send it to Model
        /// </summary>
        public static void StatesViewToModel()
        {
            GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen = Functions.isOpenCheck(Convert.ToString(Program.MainForm.BtDoorEnter.Tag));
            GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen = Functions.isOpenCheck(Convert.ToString(Program.MainForm.BtWindowSaloonL.Tag));
            GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen = Functions.isOpenCheck(Convert.ToString(Program.MainForm.BtWindowSaloonR.Tag));
            GlobalVariables.MyHouse.Walls[1].Openings[0].isOpen = Functions.isOpenCheck(Convert.ToString(Program.MainForm.BtWindowKitchen.Tag));
            GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen = Functions.isOpenCheck(Convert.ToString(Program.MainForm.BtWindowBedroom.Tag));
            GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen = Functions.isOpenCheck(Convert.ToString(Program.MainForm.BtDoorKitchen.Tag));
            GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen = Functions.isOpenCheck(Convert.ToString(Program.MainForm.BtDoorBedroom.Tag));
        }
        /// <summary>
        /// Taking all the states from Model and send it to the View
        /// </summary>
        public static void StatesModelToView()
        {
            Functions.IsOpenToView(Program.MainForm.BtDoorEnter, GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen);
            Functions.IsOpenToView(Program.MainForm.BtWindowSaloonL, GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen);
            Functions.IsOpenToView(Program.MainForm.BtWindowSaloonR, GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen);
            Functions.IsOpenToView(Program.MainForm.BtWindowKitchen, GlobalVariables.MyHouse.Walls[1].Openings[0].isOpen);
            Functions.IsOpenToView(Program.MainForm.BtWindowBedroom, GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen);
            Functions.IsOpenToView(Program.MainForm.BtDoorKitchen, GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen);
            Functions.IsOpenToView(Program.MainForm.BtDoorBedroom, GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen);
        }
        /// <summary>
        /// Taking all the temp from View and send it to the Model
        /// </summary>
        public static void TempViewToModel()
        {
            // TODO : Function qui fait quelque chose de plus beau que ça...  Je pense a une function qui a juste besoin du numéro de pièce, on aurait qu'a faire un foreach MyHouse.rooms
            // ToDO : fonction qui selectionne les bons éléments sur la vie en fonction de la room id (chauffage) ...
            // !!!!!! LOW NE PASSE PAS :(
            GlobalVariables.MyHouse.Rooms[2].temperature = Convert.ToDouble(Functions.ConvertSeparator(Program.MainForm.tBKitchenTempAct.Text));
            GlobalVariables.MyHouse.Rooms[2].temperature_order = Convert.ToDouble(Functions.ConvertSeparator(Program.MainForm.tBKitchenTempRef.Text));
            GlobalVariables.MyHouse.Rooms[3].temperature = Convert.ToDouble(Functions.ConvertSeparator(Program.MainForm.tBBedRoomTempAct.Text));
            GlobalVariables.MyHouse.Rooms[3].temperature_order = Convert.ToDouble(Functions.ConvertSeparator(Program.MainForm.tBBedRoomTempRef.Text));
            GlobalVariables.MyHouse.Rooms[1].temperature = Convert.ToDouble(Functions.ConvertSeparator(Program.MainForm.tBSaloonTempAct.Text));
            GlobalVariables.MyHouse.Rooms[1].temperature_order = Convert.ToDouble(Functions.ConvertSeparator(Program.MainForm.tBSaloonTempRef.Text));
            GlobalVariables.MyHouse.Rooms[0].temperature = Convert.ToDouble(Functions.ConvertSeparator(Program.MainForm.tBOutdoorTempAct.Text));
        }
        /// <summary>
        /// Taking all the temp from Model and send it to the View
        /// </summary>
        public static void TempModelToView()
        {
            for (int i = 1; i <= 3; i++)
            {
                Functions.changeTempView(i, Convert.ToString(GlobalVariables.MyHouse.Rooms[i].temperature));

            }
        }


    }
}
