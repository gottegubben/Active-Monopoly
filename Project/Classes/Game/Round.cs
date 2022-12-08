using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The round class represent a round in monopoly. A round is finished when all players have made their move.
    /// </summary>
    public class Round
    {
        #region Constructors:
        //This constructor will construct one round of Monopoly.
        public Round(GameData data, Delegate.SendStatisticsCallback sendStatisticsCallbackRef)
        {
            Data = data;

            SendStatisticsCallbackRef = sendStatisticsCallbackRef;
        }
        #endregion

        #region Properties:
        //The game data from the board.
        public GameData Data { get; }

        //This prop holds the reference to the statistic method for sending the state to the statistic class.
        public Delegate.SendStatisticsCallback SendStatisticsCallbackRef { get; set; }
        #endregion

        #region Methods:
        //This loop will be executed after initializing the round class. This will do everything that happens in a round, send the state to the statistic class
        //and then dispose for a new round to be created later by the game class. (Will maybe use the IDisposable interface for disposing)
        private void roundLoop()
        {
            //All players should have their own turn in a round, this will happen here.
            foreach (Player player in Data.Players)
            {
                //Checks if the current player is alive, otherwise the player can't play.
                if (player.IsAlive)
                {

                }
            }

            SendStatisticsCallbackRef(this);
        }
        #endregion
    }
}
