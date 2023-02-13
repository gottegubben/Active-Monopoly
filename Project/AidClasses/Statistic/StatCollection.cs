using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This class will contain all the stats for the game that will be important to the study but in a easier to read format.
    /// Is essentially for analyzing the data collected from the simulations easier.
    /// </summary>
    public class StatCollection
    {
        public StatCollection(Round[] rounds)
        {
            #region PlayerPedestal:
            //Check if there's one winner winners:
            List<Move> moves = rounds[rounds.Length - 1].Moves;

            //The order by amounts of properties each player has.
            List<Move> byProperty = moves.OrderBy((x) => { return x.AmountOfPropertiesOwned; }).Reverse().ToList();

            //The order by the balance each player has.
            List<Move> byMoney = moves.OrderBy((x) => { return x.PlayerBalancePost; }).Reverse().ToList();
            #endregion
        }

        #region Properties:
        //The players ranked in an order from first to last.
        public Player[] PlayerPedestal { get; set; }
        #endregion
    }
}
