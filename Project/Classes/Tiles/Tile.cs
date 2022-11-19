using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public abstract class Tile
    {
        /// <summary>
        /// The tile class will represent a tile in the game of monopoly. For instance: the "GO - tile". This will be the base class for all tiles.
        /// </summary>

        #region Properties: 
        //The name of the tile.
        public string TileName { get; }

        //The id of the tile.
        public string TileId { get; }

        //The color of the tile. For instance the color of the street.
        public Color TileColor { get; }
        #endregion
    }
}
