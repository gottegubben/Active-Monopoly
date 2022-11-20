using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This will contain the data of the tiles represented in the game of monopoly as well as the players etc.
    /// </summary>
    public class GameData
    {
        #region Properties:
        //All the tiles that will be used in the game and in there respected order.
        public List<Tile> Tiles { get; }
        
        //All the players that will be playing the game. Can be a minimum of two players.
        public List<Player> Players { get; }

        //The dices that will be used in the game.
        public List<Dice> Dices { get; }
        #endregion
    }
}
