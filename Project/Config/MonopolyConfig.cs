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

        private static CardCollecter getTileCardCollector(string tileName, int tileId, Color tileColor, CardType cardType)
        {
            return new CardCollecter(cardType)
            {
                TileName = tileName,
                TileId = tileId,
                TileColor = tileColor
            };
        }

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

        #endregion
    }
}
