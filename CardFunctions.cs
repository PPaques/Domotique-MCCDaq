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
        private Boolean CardLock = false;

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
            ULStat = MccDaq.MccService.ErrHandling(MccDaq.ErrorReporting.PrintAll, MccDaq.ErrorHandling.DontStop);

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
                
                this.CardLock = true;
            }
        }

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
            EngUnits = new float[5];

            // taking the values from the card
            for (int i = 0; i <= 4; i++)
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
                GlobalVariables.MyHouse.Rooms[i].temperature = (EngUnits[i] * 11F); //convert voltage to temperature
            }
        }


    }
}
