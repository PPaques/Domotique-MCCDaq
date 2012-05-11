using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MccDaq;
/// <summary>
/// A class that stock all the global variables
/// </summary>

namespace MyhouseDomotique
{
    /// <summary>
    /// The class that control all the car functions
    /// </summary>
    class Card
    {
        // card variables init
        private MccDaq.MccBoard DaqBoard;
        private MccDaq.ErrorInfo ULStat;
        private MccDaq.Range Range;


        // *----------------------------------------------------------------*
        // *     Initialisation and configuration of the card               *
        // *----------------------------------------------------------------*
        /// <summary>
        /// Constructor that initialise the card
        /// </summary>
        public Card()
        {
            //  Initiate error handling
            //   activating error handling will trap errors like
            //   bad channel numbers and non-configured conditions.
            //   Parameters:
            //     MccDaq.ErrorReporting.
            //              -> PrintAll  : all warnings and errorsencountered will be printed
            //              -> DontPrint : No error printing (in production) 
            //     MccDaq.ErrorHandling.
            //              -> StopAll  : If an error is encountered, the program will stop
            //              -> DontStop : No stop (in production)
            ULStat = MccDaq.MccService.ErrHandling(MccDaq.ErrorReporting.DontPrint, MccDaq.ErrorHandling.DontStop);

            // select the first card (the only connected)
            DaqBoard = new MccDaq.MccBoard(0);
            ULStat = DaqBoard.FlashLED();

            //  looking if the card is connected
            if (ULStat.Value == MccDaq.ErrorInfo.ErrorCode.NoErrors)
            {
                // if no errors, configuring the card
                GlobalVariables.mode = "normal";

                // FirstPortA as output for heating control
                ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortA, MccDaq.DigitalPortDirection.DigitalOut);
                ULStat = DaqBoard.DOut(MccDaq.DigitalPortType.FirstPortA, 0); // All is off at startup

                // FirstPortB as input for door and windows
                ULStat = DaqBoard.DConfigPort(MccDaq.DigitalPortType.FirstPortB, MccDaq.DigitalPortDirection.DigitalIn);
            }
            else
            {
                // if error, simulation mode and blocking the card
                GlobalVariables.mode = "simulation";
            }
        }

        // *----------------------------------------------------------------*
        // *     Functions to take values                                   *
        // *----------------------------------------------------------------*
        /// <summary>
        /// read the temperature and send it to the model
        /// </summary>
        public void ReadTemp()
        {
            float[] EngUnits;   // [] car array
            System.UInt16 DataValue;

            //  Collect the data by calling AIn memeber function of MccBoard object
            //   Parameters:
            //     Chan       :the input channel number
            //     Range      :the Range for the board.
            //     DataValue  :the name for the value collected
            Range = Range.Bip10Volts; // selectionne un range de 10 V

            // on définit la taille de engunit
            EngUnits = new float[4];

            // taking the values from the card
            
            for (int i = 0; i <= 3; i++)
            {
                ULStat = DaqBoard.AIn(i, Range, out DataValue);
                // on vérifie si le range est bon
                if (ULStat.Value == MccDaq.ErrorInfo.ErrorCode.BadRange)
                {
                    MessageBox.Show("Range not upported by the card.",
                        "Unsupported Range", MessageBoxButtons.OK);
                    Application.Exit();
                }

                ULStat = DaqBoard.ToEngUnits(Range, DataValue, out EngUnits[i]);// converting to voltage
                float Value = (EngUnits[i] * 100F / 11F);
                Functions.SaveTemperature(i, Value);
            }
        }
         
        /// <summary>
        /// Read all the states and send it to the model
        /// </summary>
        public void ReadStates()
        {
            short DigitalIn;
            ULStat = DaqBoard.DIn(MccDaq.DigitalPortType.FirstPortB, out DigitalIn); // read from the card

            Boolean[] Raw_states = NumberToBinaryArray(DigitalIn);
            // now we have to push this to the model, We have to pay attention because the number is inverted !!!!
            // we can't make a for because this is difficult to attributes it to a array

            GlobalVariables.MyHouse.Walls[0].Openings[0].isOpen = Raw_states[7];
            GlobalVariables.MyHouse.Walls[0].Openings[1].isOpen = Raw_states[6];
            GlobalVariables.MyHouse.Walls[0].Openings[2].isOpen = Raw_states[5];
            GlobalVariables.MyHouse.Walls[1].Openings[0].isOpen = Raw_states[4];
            GlobalVariables.MyHouse.Walls[2].Openings[0].isOpen = Raw_states[3];
            GlobalVariables.MyHouse.Walls[3].Openings[0].isOpen = Raw_states[2];
            GlobalVariables.MyHouse.Walls[4].Openings[0].isOpen = Raw_states[1];
        }

        /// <summary>
        /// Function that check the luminosity
        /// </summary>
        /// <returns></returns>
        public Boolean IsDay()
        {
            float Voltage;   // [] car array
            System.UInt16 DataValue;

            //  Collect the data by calling AIn memeber function of MccBoard object
            //   Parameters:
            //     Chan       :the input channel number
            //     Range      :the Range for the board.
            //     DataValue  :the name for the value collected
            Range = Range.Bip10Volts; // selectionne un range de 10 V

            ULStat = DaqBoard.AIn(4, Range.Bip10Volts, out DataValue);
            
            // on vérifie si le range est bon
            if (ULStat.Value == MccDaq.ErrorInfo.ErrorCode.BadRange)
            {
                MessageBox.Show("Range not upported by the card.",
                    "Unsupported Range", MessageBoxButtons.OK);
                Application.Exit();
            }

            ULStat = DaqBoard.ToEngUnits(Range, DataValue, out Voltage);// converting to voltage
            Program.MainForm.LightConfProgress.Value = Convert.ToInt16(Voltage * 100/5);


            if (Voltage >= 0.5 + 0.2 * Program.MainForm.ScrollSensibility.Value/5)
                return false;
            else
                return true;

        }

        // *----------------------------------------------------------------*
        // *     Functions to set output value                              *
        // *----------------------------------------------------------------*
        /// <summary>
        /// Send the hot states to the card.
        /// </summary>
        public void setHotStates()
        {
            for (int RoomId = 1; RoomId <= 3; RoomId++)
            {
                if (GlobalVariables.MyHouse.Rooms[RoomId].hot_is_active)
                    ULStat = DaqBoard.DBitOut(MccDaq.DigitalPortType.FirstPortA, RoomId, MccDaq.DigitalLogicState.High);
                else
                    ULStat = DaqBoard.DBitOut(MccDaq.DigitalPortType.FirstPortA, RoomId, MccDaq.DigitalLogicState.Low);
            }     
        }

        /// <summary>
        /// Send the light state to the card
        /// </summary>
        public void setLightState()
        {
            if(GlobalVariables.MyHouse.Rooms[0].light_is_active)
                ULStat = DaqBoard.DBitOut(MccDaq.DigitalPortType.FirstPortA, 0, MccDaq.DigitalLogicState.High);
            else
                ULStat = DaqBoard.DBitOut(MccDaq.DigitalPortType.FirstPortA, 0, MccDaq.DigitalLogicState.Low);
        }


        // *----------------------------------------------------------------*
        // *     Functions needed in this system                            *
        // *----------------------------------------------------------------*
        /// <summary>
        /// Convert a number to a binary array
        /// </summary>
        /// <param name="digitalBit"></param>
        /// <returns></returns>
        private Boolean[] NumberToBinaryArray(short digitalBit)
        {
            // we receive a number for the octet (0 -> 255), we have to convert it to binary
            string Binaray_string = Convert.ToString(digitalBit, 2);

            // Correcting the proble with the bug of zeros : if the number begin with 0, that is not printed
            while (Binaray_string.Length < 8)
            {
                Binaray_string = "0" + Binaray_string;
            }

            // divide in a array array
            char[] array = Binaray_string.ToCharArray();
            Boolean[] Output = new Boolean[8];

            for(int i = 0; i < 8; i++) 
            {
                if (array[i] == '0')
                    Output[i] = false;
                else
                    Output[i] = true;
            }

            return Output;
        }


    }
}
