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
        #region Methods:

        //The write method will write the desired text to the console.
        public static void Write(string message, Urgency urgency)
        {
            if(urgency == Urgency.None)
            {
                Console.WriteLine(message);
            }
            else if(urgency == Urgency.Normal)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(message);
            }
            else if(urgency == Urgency.Warning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(message);
            }
            else if (urgency == Urgency.Incorrect)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(message);
            }
            else if(urgency == Urgency.Correct)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(message);
            }
            else if(urgency == Urgency.Result)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(message);
            }

            Console.ResetColor();
        }

        //The "Time Write - method" will write the desired text but with a time stamp in front.
        public static void TimeWrite(string message, Urgency urgency)
        {
            Write($"[{DateTime.Now.ToLongTimeString()}] {message}", urgency);
        }

        //This method will paint a line in the console. For splitting up information.
        public static void PaintLine()
        {
            Console.WriteLine("-------------------------------------------------------");
        }
        
        //Writes a blank space.
        public static void PaintSpace()
        {
            Console.WriteLine();
        }

        //Paints a title.
        public static void WriteTitle(string message)
        {
            PaintLine();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Write($"[ {message} ]", Urgency.None);

            Console.ResetColor();

            PaintLine();

            /* Preview:
             
                -------------------------------------------- 
                THE TITLE
                -------------------------------------------- 

            */
        }
        #endregion
    }
}
