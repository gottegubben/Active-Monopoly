using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The log class main function is logging information to the console for debugging and observing purposes.
    /// </summary>
    public static class Log
    {
        #region Properties:
        private static ConsoleColor defBackground = ConsoleColor.Black;

        private static ConsoleColor defForeground = ConsoleColor.White;

        private static ConsoleColor information = ConsoleColor.Blue;

        private static ConsoleColor warning = ConsoleColor.Yellow;

        private static ConsoleColor destructive = ConsoleColor.Red;
        #endregion

        #region Methods:
        //"Reset Color - method" resets the colors used in the console.
        private static void resetColor()
        {
            Console.BackgroundColor = defBackground;

            Console.ForegroundColor = defForeground;
        }

        //The write method will write the desired text to the console.
        public static void Write(string message, Urgency urgency)
        {
            if(urgency == Urgency.None)
            {
                resetColor();

                Console.WriteLine(message);
            }
            else if(urgency == Urgency.Information)
            {
                resetColor();

                Console.ForegroundColor = information;

                Console.WriteLine();
            }
            else if(urgency == Urgency.Warning)
            {
                resetColor();

                Console.ForegroundColor = warning;

                Console.WriteLine();
            }
            else if (urgency == Urgency.Destructive)
            {
                resetColor();

                Console.ForegroundColor = destructive;

                Console.WriteLine();
            }
        }

        //The "Time Write - method" will write the desired text but with a time stamp in front.
        public static void TimeWrite(string message, Urgency urgency)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
