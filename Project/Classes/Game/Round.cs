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
            data.RoundCounter++;

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
                Move move = new Move(player);

                move.PlayerBalancePre = player.Balance;

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
                        #region Try to buy the property:
                        //Try to buy the property the player is standing on.
                        Tile temp = Data.Tiles[Data.PlayerPositionHandler.GetPlayerPositionInt(player)];

                        bool canBuyStreet = Data.Tiles[Data.PlayerPositionHandler.GetPlayerPositionInt(player)].CanBuyThisStreet();
                        bool hasEnoughMoney;
                        try
                        {
                            if(temp is PurchasableTile)
                            {
                                hasEnoughMoney = bot.Balance >= bot.Buffert && bot.Balance >= (temp as PurchasableTile).BaseCost;
                            }
                            else { hasEnoughMoney = false; }
                        }
                        catch { hasEnoughMoney = false; }

                        if(canBuyStreet && hasEnoughMoney)
                        {
                            bot.BuyProperty(temp as PurchasableTile);

                            move.HasBoughtProperty = true;
                        }
                        else { move.HasBoughtProperty = false; }
                        #endregion

                        #region Try to move:
                        //Tries to move the player on the game board.
                        if (player.CanMove)
                        {
                            int steps = player.Throw(Data.Dices.ToArray()).Sum();

                            move.PrePosition = Data.PlayerPositionHandler.GetPlayerPositionInt(player);

                            Data.PlayerPositionHandler.MovePlayerForward(player, steps, Data.Tiles.Count);

                            move.PostPosition = Data.PlayerPositionHandler.GetPlayerPositionInt(player);

                            //Do everything that needs to be done on that specific tile.
                            Tile landed = Data.Tiles[Data.PlayerPositionHandler.GetPlayerPositionInt(player)];

                            move.SteppedTile = landed;

                            if(landed is ActionSpace)
                            {
                                if(landed is CardCollecter)
                                {
                                    (landed as CardCollecter).Action(player, Data);
                                }
                                else if(landed is Prison)
                                {
                                    (landed as Prison).Action(player, Data);
                                }
                                else if(landed is Tax)
                                {
                                    (landed as Tax).Action(player, Data);
                                }
                            }
                            else if(landed is PurchasableTile)
                            {
                                if(landed is Property)
                                {
                                    Property prop = (landed as Property);

                                    if(prop.Owner != null && prop.Owner != player)
                                    {
                                        int rent = prop.GetRent();

                                        player.Balance -= rent;
                                        prop.Owner.Balance += rent;
                                    }
                                }
                                else if(landed is Station)
                                {
                                    Station stat = (landed as Station);

                                    if (stat.Owner != null && stat.Owner != player)
                                    {
                                        int rent = stat.GetRent(Data);

                                        player.Balance -= rent;
                                        stat.Owner.Balance += rent;
                                    }
                                }
                                else if(landed is Utility)
                                {
                                    Utility util = (landed as Utility);

                                    if (util.Owner != null && util.Owner != player)
                                    {
                                        int rent = util.GetRent(Data, player.Throw(Data.Dices[0])[0]);

                                        player.Balance -= rent;
                                        util.Owner.Balance += rent;
                                    }
                                }
                            }
                        }
                        #endregion

                        #region Try to construct buildings:
                        //For bot.constructionMax... try to perform action to build with the bot.PerformActionChance. Also find 3 pairs of streets.

                        List<PurchasableTile> ownedTiles = player.GetOwnedTiles(Data.Tiles);

                        int constructionsMade = 0;
                        bool enoughMoney = true;

                        while((player as Bot).MaxConstruction < constructionsMade && enoughMoney)
                        {
                            for (int i = 0; i < ownedTiles.Count; i++)
                            {
                                List<PurchasableTile> tiles = Data.GetTilesOfGroupIndex(ownedTiles[i].GroupIndex);

                                bool ownsAll = tiles.All((x) => x.Owner == player);

                                if (ownsAll && tiles[0] is Property)
                                {
                                    for (int y = 0; y < tiles.Count; y++)
                                    {
                                        Property prop = tiles[y] as Property;

                                        if (prop.ConstructionCost < player.Balance)
                                        {
                                            player.BuildOnProperty(prop);
                                            constructionsMade++;
                                        }
                                        else
                                        {
                                            enoughMoney = false;
                                        }
                                    }

                                    ownedTiles.Remove(ownedTiles[i]);
                                }
                            }
                        }
                        #endregion

                        #region Check if the player balance is below zero:
                        if(player.Balance < 0)
                        {
                            List<Tile> purchasableTiles = Data.Tiles.FindAll((x) => x is PurchasableTile);
                            List<Tile> owned = purchasableTiles.FindAll((x) => { if ((x as PurchasableTile).Owner == player) { return true; } else { return false; } });

                            List<PurchasableTile> ownedAsPurch = new List<PurchasableTile>();
                            foreach (Tile item in owned)
                            {
                                ownedAsPurch.Add(item as PurchasableTile);
                            }

                            //This list is sorted by the base cost of each purchasable tile, not by how much money the tile together with the buildings will come to.
                            ownedAsPurch = ownedAsPurch.OrderBy((x) => x.BaseCost).ToList();

                            //Sells as many streets as possible.
                            for (int i = 0; i < ownedAsPurch.Count; i++)
                            {
                                player.SellProperty(ownedAsPurch[i]);
                                if(player.Balance > 0) { break; }
                            } //Else resign.
                            if(player.Balance < 0)
                            {
                                player.Resign();
                            }
                        }
                        #endregion

                        List<Tile> tempTilesPurch = Data.Tiles.FindAll((x) => x is PurchasableTile).ToList();
                        move.AmountOfPropertiesOwned = tempTilesPurch.FindAll((x) => { if ((x as PurchasableTile).Owner == player) { return true; } else { return false; } }).Count;

                        int constructedBuildings = 0;
                        for (int i = 0; i < tempTilesPurch.Count; i++)
                        {
                            if(tempTilesPurch[i] is Property)
                            {
                                constructedBuildings += (tempTilesPurch[i] as Property).HouseCount;
                            }
                        }

                        move.AmountOfConstructedBuildings = constructedBuildings;
                        
                        move.PlayerBalancePost = player.Balance;

                        Moves.Add(move);
                    }
                }
            }

            SendStatisticsCallbackRef(this);
        }
        #endregion
    }
}
