using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Prison : ActionSpace
    {
        #region Constructors:
        //When the prison class is initialized it will need a tile id for the player to move to. 
        public Prison(int prisonTileId)
        {
            this.prisonTileId = prisonTileId;
        }
        #endregion

        #region Properties:
        //The id of the tile that will house the prisoner.
        private int prisonTileId { get; }
        #endregion

        #region Methods:
        //The action method will make the player unable to move temporarily and may send him to another tile.
        public override void Action()
        {
            PerformActionCallbackRef(prisonTileId, TypeOfAction.SendToPrison);
        }
        #endregion
    }
}