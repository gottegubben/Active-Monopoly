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
        public PlayerPositionHandler()
        {
            Positions = new List<PlayerPosition>();
        }
        public PlayerPositionHandler(List<Player> players)
        {
            Positions = new List<PlayerPosition>();

            for (int i = 0; i < players.Count; i++)
            {
                Positions.Add(new PlayerPosition(players[i]));
            }
        }

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
            if(currentPos > landOnTile)
            {
                player.Balance += 200;
            }
        }

        //The "move player to tile - method" will teleport the player to the chosen location. Has to be a tile on the board.
        public void MovePlayerToTile(Player player, int tileId, int tilesMax)
        {
            //Will turn true if the player wants to teleport to a tile that is avaible. Not accepted: tile id = -5.
            if (tileId < tilesMax && tileId >= 0)
            {
                //Gets the current position of the player.
                int currentPos = GetPlayerPositionInt(player);
            }
        }

        //Finds the closest tile of the designated tile type to the player and returns the id of that specific tile on the board. T is the tile type.
        public int FindClosestTile<T>(Player player, List<Tile> boardTiles)
        {
            //This distance is impossible.
            int distance = boardTiles.Count;

            //The default is set to -1 if it can't find a tile of type T close to the player. The reason behind this is if there's no tiles of type T on the board.
            int targetId = -1;

            //All the tiles of type T.
            List<Tile> tilesOfTypeT = new List<Tile>();

            //Fetches all the tiles that can be converted to type T.
            foreach (Tile item in boardTiles)
            {
                if(item is T)
                {
                    tilesOfTypeT.Add(item);
                }
            }

            //Gets the targetId which will be the closest tile to the player.
            for (int i = 0; i < tilesOfTypeT.Count; i++)
            {
                int dist = tilesOfTypeT[i].TileId - GetPlayerPositionInt(player);

                if (dist < distance)
                {
                    targetId = tilesOfTypeT[i].TileId;

                    distance = dist;
                }
            }

            return targetId;
        }
        #endregion
    }
}
