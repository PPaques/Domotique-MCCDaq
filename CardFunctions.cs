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




    }
}
