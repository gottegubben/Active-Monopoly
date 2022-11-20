using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Go : ActionSpace
    {
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
