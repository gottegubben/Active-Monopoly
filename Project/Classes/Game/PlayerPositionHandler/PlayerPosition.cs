using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The player position class is a class that contains a position of a player. The reference to the player is the player id.
    /// </summary>
    public class PlayerPosition
    {
        #region Properties:
        //The player id will help identify what player's position it is.
        public int PlayerId { get; set; }

        //The position of hte player.
        public int Position { get; set; }
        #endregion
    }
}
