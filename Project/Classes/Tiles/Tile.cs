using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The tile class will represent a tile in the game of monopoly. For instance: the "GO - tile". This will be the base class for all tiles.
    /// </summary>
    public class Tile
    {
        #region Properties: 
        //The name of the tile.
        public string TileName { get; set; }

        //The id of the tile.
        public int TileId { get; set; }

        //The color of the tile. For instance the color of the street.
        public Color TileColor { get; set; }
        #endregion

        #region Methods:
        //Returns the type of tile as a string. If it's just a blank tile, return tile.
        public string GetTypeOfTile()
        {
            throw new NotImplementedException();
        }

        //Returns true if the street is avaible for purchase.
        public bool CanBuyThisStreet()
        {
            if(this is PurchasableTile)
            {
                if((this as PurchasableTile).Owner == null)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
