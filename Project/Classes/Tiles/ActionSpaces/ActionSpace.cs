using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public abstract class ActionSpace : Tile
    {
        #region Properties:
        public Action callbackReference { get; set; }
        #endregion

        #region Methods:
        //A method which will execute the action that corresponds to the tile.
        public abstract void Action();
        #endregion
    }
}
