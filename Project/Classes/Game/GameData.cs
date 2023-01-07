using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This will contain the data of all the useful things that the game of monopoly have to initialize.
    /// </summary>
    public class GameData
    {
        #region Checklist:
        //Kanske bestämma en kostnad som säger hur mycket det kostar att fly från fängelset.

        //Hur många rundor man annars stannar i fängelset (ifall man inte betalar eller slår rätt tärning).
        #endregion

        #region Properties:
        //All the tiles that will be used in the game and in there respected order.
        public List<Tile> Tiles { get; }
        
        //All the players that will be playing the game. Can be a minimum of two players.
        public List<Player> Players { get; }

        //The dices that will be used in the game.
        public List<Dice> Dices { get; }

        //The action handler for the game.
        public ActionHandler ActionHandler { get; }

        //The player position handler handles all the player positions.
        public PlayerPositionHandler PlayerPositionHandler { get; set; }
        #endregion

        #region Methods:
        //Returns all the "purchasable tiles" that the player owns.
        public List<PurchasableTile> GetTilesOfOwner(Player player)
        {
            List<PurchasableTile> returnValue = new List<PurchasableTile>();

            foreach (Tile item in Tiles)
            {
                try
                {
                    PurchasableTile temp = item as PurchasableTile;

                    if(temp.Owner == player)
                    {
                        returnValue.Add(temp);
                    }
                }
                catch { }
            }

            return returnValue;
        }
        #endregion
    }
}
