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
        public PlayerPosition()
        {

        }
        public PlayerPosition(Player player)
        {
            PlayerId = player.Id;
            Position = 0;
        }

        #region Properties:
        //The player id will help identify what player's position it is.
        public int PlayerId { get; set; }

        //The position of the player.
        public int Position { get; set; }
        #endregion
    }
}
