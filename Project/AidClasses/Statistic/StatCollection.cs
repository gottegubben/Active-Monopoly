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
        #region Constructors:
        public StatCollection(Round[] rounds)
        {
            #region Pedestal:
            //Check if there's one winner winners:
            List<Move> moves = rounds[rounds.Length - 1].Moves;

            //The order by amounts of properties each player has.
            List<Move> byProperty = moves.OrderBy((x) => { return x.AmountOfPropertiesOwned; }).Reverse().ToList();

            //The order by the balance each player has.
            List<Move> byMoney = moves.OrderBy((x) => { return x.PlayerBalancePost; }).Reverse().ToList();

            //Order by networth (the tiles cost + building cost)
            Round lastRound = rounds[rounds.Length - 1];

            foreach (Tile item in lastRound.Data.Tiles)
            {
                if(item is PurchasableTile)
                {
                    PurchasableTile temp = (item as PurchasableTile);

                    if(temp.Owner != null)
                    {
                        temp.Owner.FinalNetworth += temp.BaseCost;

                        if (temp is Property)
                        {
                            Property prop = temp as Property;
                            temp.Owner.FinalNetworth += prop.ConstructionCost * prop.HouseCount;
                        }
                    }
                }
            }

            List<Move> byNetWorth = moves.OrderBy((x) => { return x.Player.FinalNetworth; }).Reverse().ToList();

            List<Player> playerped = new List<Player>();
            foreach (Move item in byNetWorth)
            {
                playerped.Add(item.Player);
            }

            PlayerPedestal = playerped.ToArray();
            #endregion

            #region RentCount:

            RentCountOfTile = new int[rounds[0].Data.Tiles.Count];

            foreach (Round rnd in rounds)
            {
                foreach (Move mv in rnd.Moves)
                {
                    if (mv.PaidRent)
                    {
                        RentCountOfTile[mv.SteppedTile.TileId]++;
                    }
                }
            }

            #endregion
        }
        #endregion

        #region Properties:
        //The players ranked in an order from first to last.
        public Player[] PlayerPedestal { get; set; }

        //An index is the corresponding tile id and this will store how many times a player had to pay rent on a specific tile under the match.
        public int[] RentCountOfTile { get; set; }
        #endregion
    }
}
