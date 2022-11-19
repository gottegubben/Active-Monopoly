using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    abstract public class PurchasableTile : Tile
    {
        /// <summary>
        /// This class will represent all the purchasable tiles in the game of Monopoly.
        /// </summary>

        #region Properties:
        //The index of the group correlated to the tile. For instance can there be 3 streets and they all have the same group index to indicate that they are correlated.
        public int GroupIndex { get; }

        //The player that owns the property.
        public Player Owner { get; private set; }
        #endregion

        #region Methods:
        //Changes the current owner of the tile to a new owner.
        public void ChangeOwner(Player newOwner)
        {
            Owner = newOwner;
        }

        public virtual void GetRent(int houses)
        {

        }
        #endregion
    }
}
