using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This is a static class that should be used for containing and sorting all the delegates that may be used in this program.
    /// </summary>
    public static class Delegate
    {
        #region Properties:
        //This delegates is for creating a reference for action based callbacks.
        public delegate void PerformActionCallback(object value, TypeOfAction typeOfAction);

        //This delegate is used for the round class to send the state of the game to the statistic class after a round.
        public delegate void SendStatisticsCallback(Round data);
        #endregion
    }
}
