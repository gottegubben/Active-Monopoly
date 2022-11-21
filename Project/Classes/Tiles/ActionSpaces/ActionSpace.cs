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
        //The callback method will work as a blueprint for the type of method that it should contain.
        public delegate void Callback(object value, TypeOfAction typeOfAction);

        //This is the prop that will hold the reference to the callback function.
        public Callback CallbackReference { get; set; }
        #endregion

        #region Methods:
        //A method which will execute the action that corresponds to the tile.
        public abstract void Action();
        #endregion
    }
}
