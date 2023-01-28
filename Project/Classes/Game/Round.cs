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

            Moves = new List<Move>();

            SendStatisticsCallbackRef = sendStatisticsCallbackRef;

            //Play the round.
            roundLoop();
        }
        #endregion

        #region Properties:
        //The game data from the board.
        public GameData Data { get; }

        //The moves that the players make during a round of Monopoly.
        public List<Move> Moves { get; set; }

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
                    Bot bot = player as Bot;

                    /* Order:
                     * Testa ifall man kan köpa gatan.
                     * Ifall man ej är i fängelse, slå tärningen och gå.
                     * Köp hus/hotell.
                     * Se hur mycket pengar individen har så att hen inte är bankrupt.
                    */

                    if (player.IsAlive)
                    {
                        //Try to buy the property the player is standing on.
                        Tile temp = Data.Tiles[Data.PlayerPositionHandler.GetPlayerPositionInt(player)];

                        bool canBuyStreet = Data.Tiles[Data.PlayerPositionHandler.GetPlayerPositionInt(player)].CanBuyThisStreet();
                        bool hasEnoughMoney;
                        try
                        {
                            hasEnoughMoney = bot.Balance >= bot.Buffert && bot.Balance >= (temp as PurchasableTile).BaseCost;
                        }
                        catch { hasEnoughMoney = false; }

                        if(canBuyStreet && hasEnoughMoney)
                        {
                            bot.BuyProperty(temp as PurchasableTile);
                        }
                    }


                    //Test to buy the street.
                }
            }

            SendStatisticsCallbackRef(this);
        }
        #endregion
    }
}
