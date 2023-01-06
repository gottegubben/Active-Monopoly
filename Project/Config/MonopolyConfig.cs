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
        private static List<CardDeck> getCardDecks()
        {
            CardDeck community = new CardDeck()
            {
                Cards = new List<Card>()
                {
                    new Card("Du beskattas för gatureparationer. Betala $40 för varje hus och $115 för varje hotell du äger.", (Player player, GameData data) => { player.Balance -= 40; }),
                    new Card("Fortsätt till gå (Inkassera $200).", (Player player, GameData data)=>{data.PlayerPositionHandler.MovePlayerToTile(player, 0, data.Tiles.Count); player.Balance += 200; })
                }
            };

            CardDeck chance = new CardDeck()
            {

            };

            return new List<CardDeck>()
            {
                community,
                chance
            };
        }
        #region Comments:
        /*
            Community:
            1. Du beskattas för gatureparationer. Betala $40 för varje hus och $115 för varje hotell du äger.
            2. Fortsätt till gå (Inkassera $200).
            3. Du säljer aktier och får $50.
            4. Läkararvode. Betala $50.
            5. Du erhåller $25 i konsultarvode.
            6. Återbäring på livsförsäkring. Inkassera $100.
            7. Du har vunnit andra pris i en skönhetstävling. Inkassera $10.
            8. Gå i fängelse utan att passera gå.
            9. Du slipper ut ur fängelset. Du kan behålla kortet tills du behöver det eller sälja det. (Ska ej vara med)
            10. Banken gör ett misstag som gynnar dig. Inkassera $200.
            11. Semesterfonden stiger i värde. Du erhåller $100.
            12. Sjukhusräkning. Betala $100.
            13. Återbetalning av inkomstskatt. Inkassera $20.
            14. Du ärver $100.
            15. Terminsavgift till skolan. Betala $50.
            16. Det är din födelsedag. Inkassera $10 från varje spelare. (Ska ej vara med)

            Chans:
            1. Gå vidare till närmaste statliga verk. Om ingen äger det, kan du köpa det från banken. Om någon äger det slår du
            tärningarna och betalar ägaren 10 gånger värdet som slogs.
            2. Gå vidare till närmaste järnvägsstation. Om ingen äger den kan du köpa den från banken. Om någon äger den betalar du
            ägaren dubbla hyran mot vad hen har rätt till.
            3. Gå vidare till hamngatan. Om du passerar gå, inkassera $200.
            4. Du slipper ut ur fängelset. Du kan behålla kortet tills du behöver det eller säljer det. (Ska ej vara med)
            5. Du måste reparera alla dina egendomar. Betala $25 för varje hus och $100 för varje hotell du äger.
            6. Du får $50 i återbäring från banken.
            7. Fortkörningsböter, betala $15.
            8. Ditt bygglön förfaller. Inkassera $150.
            9. Gå tillbaka tre steg.
            10. Gå vidare till gå (Inkassera $200).
            11. Gå till södra station. Om du passerar gå, inkassera $200.
            12. Du har valts till styrelseordförande. Betala $50 till varje spelare.
            13. Gå vidare till normalmstorg.
            14. Gå vidare till S:T Eriksgatan. Om du passerar gå, inkassera $200.
            15. Gå i fängelse. Gå direkt i fängelse utan att passera gå. Inkassera inte $200.
        */
        #endregion
        #endregion

        #region GetGameData
        //Get all the game data from this function.

        //Get all the data.

        //Get all the data with custom players (bots).
        #endregion

        #endregion
    }
}
