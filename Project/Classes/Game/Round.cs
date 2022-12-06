using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The round class represent a round in monopoly. A round is finished when all players have made their move.
    /// </summary>
    public class Round
    {
        #region Constructors:
        //This constructor will construct one round of Monopoly.
        public Round(GameData data, Delegate.SendStatisticsCallback sendStatisticsCallbackRef)
        {
            Data = data;

            SendStatisticsCallbackRef = sendStatisticsCallbackRef;
        }
        #endregion

        #region Properties:
        //The game data from the board.
        public GameData Data { get; }

        //This prop holds the reference to the statistic method for sending the state to the statistic class.
        public Delegate.SendStatisticsCallback SendStatisticsCallbackRef { get; set; }
        #endregion

        #region Methods:
        //This loop will be executed after initializing the round class. This will do everything that happens in a round, send the state to the statistic class
        //and then dispose for a new round to be created later by the game class. (Will maybe use the IDisposable interface for disposing)
        private void roundLoop()
        {
            //All players should have their own turn in a round, this will happen here.
            foreach (Player player in Data.Players)
            {
                //Checks if the current player is alive, otherwise the player can't play.
                if (player.IsAlive)
                {

                }
            }

            SendStatisticsCallbackRef(this);
        }

        //The "move player forward - method" will move the player forward x steps and set the new position. This method will check if the player has walked over the "GO - tile".
        private void movePlayerForward(Player player, int steps)
        {
            //Will retrieve the current position of the player.
            int currentPos = Data.PlayerPositionHandler.GetPlayerPositionInt(player);

            //This will find the tile id that the player will walk to. "Data.Tile.Count" is the amount of tiles on the board.
            int landOnTile = (currentPos + steps) % Data.Tiles.Count;

            //Changes the position of the player.
            Data.PlayerPositionHandler.SetPlayerPosition(player, landOnTile);

            //This method should also check if the player has walked over the "GO - tile".
        }

        //The "move player to tile - method" will teleport the player to the chosen location. Has to be a tile on the board.
        private void movePlayerToTile(Player player, int tileId)
        {
            //Will turn true if the player wants to teleport to a tile that is avaible. Not accepted: tile id = -5.
            if(tileId < Data.Tiles.Count && tileId >= 0)
            {
                //Gets the current position of the player.
                int currentPos = Data.PlayerPositionHandler.GetPlayerPositionInt(player);

                
            }
        }
        #endregion
    }
}
