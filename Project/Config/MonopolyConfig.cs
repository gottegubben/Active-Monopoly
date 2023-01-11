using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The static class of monopoly config will contain fucntions that will return hard coded values for the game of Monopoly.
    /// </summary>
    public static class MonopolyConfig
    {
        #region Methods:

        #region GetDices
        
        //Returns all the normal dices. The random should be definied in the simulation which will result it being different for every new game simulated.
        public static List<Dice> GetDices(Random rnd)
        {
            return new List<Dice>()
            {
                new Dice(rnd.Next(1, 100000)),
                new Dice(rnd.Next(1, 100000))
            };
        }

        #endregion

        #region GetTiles:
        //Fetches the go tile.
        private static Go getTileGo(int tileId, int rent)
        {
            return new Go(rent)
            {
                TileName = "Go",
                TileId = tileId,
                TileColor = Color.White
            };
        }

        //Returns the prison tile.
        private static Prison getTilePrison(string tileName, int tileId, int prisonTileId)
        {
            return new Prison(prisonTileId)
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = Color.White
            };
        }

        //Returns a property with the following params.
        private static Property getTileProperty(string tileName, int tileId, Color tileColor, int groupIndex, int baseCost, int constructionCost, params int[] rent)
        {
            return new Property(constructionCost, rent)
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = tileColor,
                GroupIndex = groupIndex,
                BaseCost = baseCost
                
            };
        }

        //Returns a station with the following params.
        private static Station getTileStation(string tileName, int tileId, Color tileColor, int groupIndex, int baseCost, params int[] rent)
        {
            return new Station(rent)
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = tileColor,
                GroupIndex = groupIndex,
                BaseCost = baseCost
            };
        }

        //Returns a utility with the following params.
        private static Utility getTileUtility(string tileName, int tileId, Color tileColor, int groupIndex, int baseCost)
        {
            return new Utility()
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = tileColor,
                GroupIndex = groupIndex,
                BaseCost = baseCost
            };
        }

        //Returns a tax tile with the following params.
        private static Tax getTileTax(string tileName, int tileId, Color tileColor, int tax)
        {
            return new Tax(tax)
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = tileColor
            };
        }

        //Returns the tile responsible for the player picking up cards with these params.
        private static CardCollecter getTileCardCollector(string tileName, int tileId, Color tileColor, CardType cardType)
        {
            return new CardCollecter(cardType)
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = tileColor
            };
        }

        //Returns a blank tile.
        private static Tile getTileBlank(string tileName, int tileId, Color tileColor)
        {
            return new Tile()
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = tileColor
            };
        }

        //This function will return all the tiles.
        public static List<Tile> GetTiles()
        {
            //Station group index = 0
            //Utility group index = 1

            //Station rent:
            int[] stationRent = new int[] { };

            return new List<Tile>()
            {
                getTileGo(0, 200),

                getTileProperty("Sergels torg", 1, Color.Brown, 2, 0, 0, new int[]{}),
                getTileCardCollector("Allmän", 2, Color.White, CardType.CommunityChest),
                getTileProperty("Medborgarplatsen", 3, Color.Brown, 2, 0, 0, new int[]{}),
                getTileTax("Skatt", 2, Color.White, 0),
                getTileStation("Slussen", 5, Color.White, 0, 0, stationRent),
                getTileProperty("Hammarby sjöstad", 6, Color.LightBlue, 3, 0, 0, new int[]{}),
                getTileCardCollector("Chans", 7, Color.White, CardType.Fortune),
                getTileProperty("Hornstull", 8, Color.LightBlue, 3, 0, 0, new int[]{}),
                getTileProperty("Sveavägen", 9, Color.LightBlue, 3, 0, 0, new int[]{}),

                getTileBlank("Fängelsebesök", 10, Color.White),

                getTileProperty("Hantverkargatan", 11, Color.Pink, 4, 0, 0, new int[]{}),
                getTileUtility("Kaknästornet", 12, Color.White, 1, 0),
                getTileProperty("Götgatsbacken", 13, Color.Pink, 4, 0, 0, new int[]{}),
                getTileProperty("S:T Eriksgatan", 14, Color.Pink, 4, 0, 0, new int[]{}),
                getTileStation("Fridhemsplan", 15, Color.White, 0, 0, stationRent),
                getTileProperty("Drottning-gatan", 16, Color.Orange, 5, 0, 0, new int[]{}),
                getTileCardCollector("Allmän", 17, Color.White, CardType.CommunityChest),
                getTileProperty("Birgerjarlsgatan", 18, Color.Orange, 5, 0, 0, new int[]{}),
                getTileProperty("Kungsgatan", 19, Color.Orange, 5, 0, 0, new int[]{}),
                getTileBlank("Gratis parkering", 20, Color.White),
                getTileProperty("Mariatorget", 21, Color.Red, 6, 0, 0, new int[]{}),
                getTileCardCollector("Chans", 22, Color.White, CardType.Fortune),
                getTileProperty("Hötorget", 23, Color.Red, 6, 0, 0, new int[]{}),
                getTileProperty("Odenplan", 24, Color.Red, 6, 0, 0, new int[]{}),
                getTileStation("T-centralen", 25, Color.White, 0, 0, stationRent),
                getTileProperty("Kungsträdgården", 26, Color.Yellow, 7, 0, 0, new int[]{}),
                getTileProperty("Norrmälarstrand", 27, Color.Yellow, 7, 0, 0, new int[]{}),
                getTileUtility("Globen", 28, Color.White, 1, 0),
                getTileProperty("Hamngatan", 29, Color.Yellow, 7, 0, 0, new int[]{}),

                getTilePrison("Gå i fängelse", 30, 10),

                getTileProperty("Gamla stan", 31, Color.Green, 8, 0, 0, new int[]{}),
                getTileProperty("Östermalmstorg", 32, Color.Green, 8, 0, 0, new int[]{}),
                getTileCardCollector("Allmän", 33, Color.White, CardType.CommunityChest),
                getTileProperty("Norrmalmstorg", 34, Color.Green, 8, 0, 0, new int[]{}),
                getTileStation("Östermalmstorg", 35, Color.White, 0, 0, stationRent),
                getTileCardCollector("Chans", 36, Color.White, CardType.Fortune),
                getTileProperty("Djurgården", 37, Color.Blue, 9, 0, 0, new int[]{}),
                getTileTax("Skatt", 38, Color.White, 0),
                getTileProperty("Strandvägen", 39, Color.Blue, 9, 0, 0, new int[]{})
            };
        }
        #endregion

        #region GetCards:
        public static List<CardDeck> GetCardDecks()
        {
            //Copy paste : new Card("", (Player player, GameData data) => {})

            CardDeck community = new CardDeck(true)
            {
                Cards = new List<Card>()
                {
                    //13 x cards.
                    new Card("Du beskattas för gatureparationer. Betala $40 för varje hus och $115 för varje hotell du äger.", (Player player, GameData data) => {
                        List<PurchasableTile> temp = data.GetTilesOfOwner(player);
                        int houses = 0;
                        int hotels = 0;

                        foreach (PurchasableTile item in temp)
                        {
                            try
                            {
                                Property prop = item as Property;

                                if(prop.HouseCount > 4)
                                {
                                    hotels += prop.HouseCount - 4;
                                }
                                else
                                {
                                    houses += prop.HouseCount;
                                }
                            }
                            catch{}
	                    }

                        player.Balance -= ((40 * houses) + (115 * hotels));
                    }),
                    new Card("Fortsätt till gå (Inkassera $200).", (Player player, GameData data)=>{data.PlayerPositionHandler.MovePlayerToTile(player, 0, data.Tiles.Count); player.Balance += 200; }),
                    new Card("Du säljer aktier och får $50.", (Player player, GameData data) => {player.Balance += 50; }),
                    new Card(" Du erhåller $25 i konsultarvode.", (Player player, GameData data) => {player.Balance += 25; }),
                    new Card("Återbäring på livsförsäkring. Inkassera $100.", (Player player, GameData data) => {player.Balance += 100; }),
                    new Card("Du har vunnit andra pris i en skönhetstävling. Inkassera $10.", (Player player, GameData data) => {player. Balance += 10; }),
                    new Card("Gå i fängelse utan att passera gå.", (Player player, GameData data) => {}),
                    new Card("Banken gör ett misstag som gynnar dig. Inkassera $200.", (Player player, GameData data) => {player.Balance += 200; }),
                    new Card("Semesterfonden stiger i värde. Du erhåller $100.", (Player player, GameData data) => {player.Balance += 100; }),
                    new Card("Sjukhusräkning. Betala $100.", (Player player, GameData data) => {player.Balance -= 100; }),
                    new Card("Återbetalning av inkomstskatt. Inkassera $20.", (Player player, GameData data) => {player.Balance += 20; }),
                    new Card("Du ärver $100.", (Player player, GameData data) => {player.Balance += 100; }),
                    new Card("Terminsavgift till skolan. Betala $50.", (Player player, GameData data) => {player.Balance -= 50; })
                }
            };

            CardDeck chance = new CardDeck(true)
            {
                Cards = new List<Card>()
                {
                    //14 x cards.
                    new Card("Gå vidare till närmaste statliga verk. Om ingen äger det, kan du köpa det från banken. Om någon äger det slår du tärningarna och betalar ägaren 10 gånger värdet som slogs.", (Player player, GameData data) => {
                        int tileId = data.PlayerPositionHandler.FindClosestTile<Utility>(player, data.Tiles);

                        PurchasableTile tile = (data.Tiles[tileId] as PurchasableTile);
                        Player owner = tile.Owner;

                        if(owner != null)
                        {
                            int propertyCount = data.GetOwnedGroupIndexCount(player, tile);

                            int rent = (tile as Utility).GetRent(propertyCount, player.Throw(data.Dices.ToArray()).Sum());

                            player.Balance -= rent;

                            owner.Balance += rent;
                        }
                        else
                        {
                            //Try to buy the property.
                        }
                    }),
                    new Card("Gå vidare till närmaste järnvägsstation. Om ingen äger den kan du köpa den från banken. Om någon äger den betalar du ägaren dubbla hyran mot vad hen har rätt till.", (Player player, GameData data) => {
                        int tileId = data.PlayerPositionHandler.FindClosestTile<Station>(player, data.Tiles);

                        PurchasableTile tile = (data.Tiles[tileId] as PurchasableTile);
                        Player owner = tile.Owner;

                        if(owner != null)
                        {
                            int propertyCount = data.GetOwnedGroupIndexCount(player, tile);

                            int rent = (tile as Station).GetRent(propertyCount);

                            player.Balance -= rent;

                            owner.Balance += rent;
                        }
                        else
                        {
                            //Try to buy the property.
                        }
                    }),
                    new Card("Gå vidare till hamngatan. Om du passerar gå, inkassera $200.", (Player player, GameData data) => {
                        data.PlayerPositionHandler.MovePlayerToTile(player, 29, 40);

                        if(data.PlayerPositionHandler.GetPlayerPositionInt(player) > 29)
                        {
                            player.Balance += 200;
                        }
                    }),
                    new Card("Du måste reparera alla dina egendomar. Betala $25 för varje hus och $100 för varje hotell du äger.", (Player player, GameData data) => {
                        List<PurchasableTile> temp = data.GetTilesOfOwner(player);
                        int houses = 0;
                        int hotels = 0;

                        foreach (PurchasableTile item in temp)
                        {
                            try
                            {
                                Property prop = item as Property;

                                if(prop.HouseCount > 4)
                                {
                                    hotels += prop.HouseCount - 4;
                                }
                                else
                                {
                                    houses += prop.HouseCount;
                                }
                            }
                            catch{}
                        }

                        player.Balance -= ((25 * houses) + (100 * hotels));
                    }),
                    new Card("Du får $50 i återbäring från banken.", (Player player, GameData data) => {player.Balance += 50; }),
                    new Card("Fortkörningsböter, betala $15.", (Player player, GameData data) => {player.Balance -= 15; }),
                    new Card("Ditt bygglån förfaller. Inkassera $150.", (Player player, GameData data) => {player.Balance += 150; }),
                    new Card("Gå tillbaka tre steg.", (Player player, GameData data) => {data.PlayerPositionHandler.MovePlayerForward(player, (40-3), 40); }),
                    new Card("Gå vidare till gå (Inkassera $200).", (Player player, GameData data) => {
                        player.Balance += 200;
                        data.PlayerPositionHandler.MovePlayerToTile(player, 0, 40);
                    }),
                    new Card("Gå till södra station. Om du passerar gå, inkassera $200.", (Player player, GameData data) => {
                        data.PlayerPositionHandler.MovePlayerToTile(player, 25, 40);

                        if(data.PlayerPositionHandler.GetPlayerPositionInt(player) > 25)
                        {
                            player.Balance += 200;
                        }
                    }),
                    new Card("Du har valts till styrelseordförande. Betala $50 till varje spelare.", (Player player, GameData data) => {
                        player.Balance -= 50 * 2;
                        foreach (Player item in data.Players)
                            {
                                item.Balance += 50;
	                        }
                    }),
                    new Card("Gå vidare till Normalmstorg.", (Player player, GameData data) => {
                        data.PlayerPositionHandler.MovePlayerToTile(player, 34, 40);
                    }),
                    new Card("Gå vidare till S:T Eriksgatan. Om du passerar gå, inkassera $200.", (Player player, GameData data) => {
                        data.PlayerPositionHandler.MovePlayerToTile(player, 14, 40);

                        if(data.PlayerPositionHandler.GetPlayerPositionInt(player) > 14)
                        {
                            player.Balance += 200;
                        }
                    }),
                    new Card("Gå i fängelse. Gå direkt i fängelse utan att passera gå. Inkassera inte $200.", (Player player, GameData data) => {
                        player.CanMove = false;

                        data.PlayerPositionHandler.MovePlayerToTile(player, 10, 40);
                    })
                }
            };

            return new List<CardDeck>()
            {
                community,
                chance  
            };
        }
        #endregion

        #region GetBots

        //Aggressive - Max
        public static Bot GetAggressiveMaxBot()
        {
            return new Bot(1, 1);
        }

        //Aggressive - Min
        public static Bot GetAggressiveMinBot()
        {
            return new Bot(0.75, 0.75);
        }

        //Balanced
        public static Bot GetBalancedBot()
        {
            return new Bot(0.5, 0.5);
        }

        //Passive
        public static Bot GetPassiveBot()
        {
            return new Bot(0.25, 0.25);
        }

        //Braindead
        public static Bot GetBraindeadBot()
        {
            return new Bot(0, 0);
        }
        
        #endregion

        #region GetGameData
        //Returns the gamedata that is usually represented in the game of monopoly. The players need to be added later.
        public static GameData GetGameData(Random rnd)
        {
            return new GameData()
            {
                Tiles = GetTiles(),

                Dices = GetDices(rnd),

                PlayerPositionHandler = new PlayerPositionHandler(),

                //Finds all the actionspaces in the "getTiles - list" and converts them to actionspaces.
                ActionHandler = new ActionHandler(GetTiles().FindAll(x =>
                {
                    return x is ActionSpace;
                }).ConvertAll(y => 
                    { 
                        return y as ActionSpace; 
                    }))
            };
        }
        #endregion

        #endregion
    }
}
