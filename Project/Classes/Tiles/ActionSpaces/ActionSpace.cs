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
        //This is the prop that will hold the reference to the callback function.
        public Delegate.PerformActionCallback PerformActionCallbackRef { get; set; }
        #endregion

        #region Methods:
        //A method which will execute the action that corresponds to the tile.
        public abstract void Action(Player player, GameData data);
        #endregion
    }
}
