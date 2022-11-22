using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The go tile is the starting tile where all the players start in the beginning of the game.
    /// When passing this tile the player recieves x amount of cash depending on what the params for the constructor is.
    /// </summary>
    public class Go : ActionSpace
    {
        #region Consturctors:
        //This will be the default constructor for the go tile. The pass go revenue is the money that the player will recieve after passing go.
        public Go(int passGoRevenue)
        {
            revenue = passGoRevenue;
        }
        #endregion

        #region Properties:
        //The value of the money the player will be given after passing this tile.
        private int revenue { get; }
        #endregion

        #region Methods:
        //This method will give the player money for passing the tile. 
        public override void Action()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
