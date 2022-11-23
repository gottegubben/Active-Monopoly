using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This class will represent all the purchasable tiles in the game of Monopoly.
    /// </summary>
    abstract public class PurchasableTile : Tile
    {
        #region Properties:
        //The cost to purchase the tile.
        public int BaseCost { get; set; }

        //The index of the group correlated to the tile. For instance can there be 3 streets and they all have the same group index to indicate that they are correlated.
        public int GroupIndex { get; set; }

        //The player that owns the property.
        public Player Owner { get; private set; }
        #endregion

        #region Methods:
        //Changes the current owner of the tile to a new owner.
        public void ChangeOwner(Player newOwner)
        {
            Owner = newOwner;
        }

        //Will work as a base method for fetching the rent data for specifik subclasses.
        public virtual int GetRent() { return 0; }
        #endregion
    }
}
