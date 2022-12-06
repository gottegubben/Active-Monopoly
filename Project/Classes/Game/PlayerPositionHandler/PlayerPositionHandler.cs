using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The player position handler handles all the positions of the players.
    /// </summary>
    public class PlayerPositionHandler
    {
        #region Properties:
        //The positions of the players.
        public List<PlayerPosition> Positions { get; set; }
        #endregion

        #region Methods:
        //This method returns a value of type "playerPosition". This method has more options than the one that only returns the position.
        public PlayerPosition GetPlayerPosition(Player player)
        {
            return Positions.Find(x => x.PlayerId == player.Id);
        }

        //This method will return the position as a integer.
        public int GetPlayerPositionInt(Player player)
        {
            return GetPlayerPosition(player).Position;
        }

        public void SetPlayerPosition(Player player, int value)
        {
            Positions.Find(x => x.PlayerId == player.Id).Position = value;
        }
        #endregion
    }
}
