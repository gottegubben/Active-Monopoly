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

        //Sets the player position.
        public void SetPlayerPosition(Player player, int value)
        {
            Positions.Find(x => x.PlayerId == player.Id).Position = value;
        }

        //The "move player forward - method" will move the player forward x steps and set the new position. This method will check if the player has walked over the "GO - tile".
        public void MovePlayerForward(Player player, int steps, int tilesTotal)
        {
            //Will retrieve the current position of the player.
            int currentPos = GetPlayerPositionInt(player);

            //This will find the tile id that the player will walk to. "Data.Tile.Count" is the amount of tiles on the board.
            int landOnTile = (currentPos + steps) % tilesTotal;

            //Changes the position of the player.
            SetPlayerPosition(player, landOnTile);

            //This method should also check if the player has walked over the "GO - tile".
        }

        //The "move player to tile - method" will teleport the player to the chosen location. Has to be a tile on the board.
        public void MovePlayerToTile(Player player, int tileId, int tilesTotal)
        {
            //Will turn true if the player wants to teleport to a tile that is avaible. Not accepted: tile id = -5.
            if (tileId < tilesTotal && tileId >= 0)
            {
                //Gets the current position of the player.
                int currentPos = GetPlayerPositionInt(player);
            }
        }
        #endregion
    }
}
