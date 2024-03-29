﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This will contain the data of all the useful things that the game of monopoly have to initialize.
    /// </summary>
    public class GameData
    {
        #region Checklist:
        //Kanske bestämma en kostnad som säger hur mycket det kostar att fly från fängelset.

        //Hur många rundor man annars stannar i fängelset (ifall man inte betalar eller slår rätt tärning).
        #endregion

        #region Properties:
        //The random object of this object.
        public Random Rnd { get; set; }

        //All the tiles that will be used in the game and in there respected order.
        public List<Tile> Tiles { get; set; }
        
        //All the players that will be playing the game. Can be a minimum of two players.
        public List<Player> Players { get; set; }

        //The dices that will be used in the game.
        public List<Dice> Dices { get; set; }

        //The action handler for the game.
        public ActionHandler ActionHandler { get; set; }

        //The player position handler handles all the player positions.
        public PlayerPositionHandler PlayerPositionHandler { get; set; }

        //Counts the amount of rounds that have been played.
        public int RoundCounter { get; set; }

        public bool NormalizedBotPicks { get; set; }
        #endregion

        #region Methods:
        //Returns all the "purchasable tiles" that the player owns.
        public List<PurchasableTile> GetTilesOfOwner(Player player)
        {
            List<PurchasableTile> returnValue = new List<PurchasableTile>();

            foreach (Tile item in Tiles)
            {
                try
                {
                    PurchasableTile temp = item as PurchasableTile;

                    if(temp.Owner == player)
                    {
                        returnValue.Add(temp);
                    }
                }
                catch { }
            }

            return returnValue;
        }

        //A little hard to create a good name for this function without having it being super long. This function will return the amount of tiles the player owns that has the
        //same group index as the tile you put in. Essentially this will be useful if you, for instance, want to know how many stations the player possess.
        public int GetOwnedGroupIndexCount(Player player, PurchasableTile tile)
        {
            int returnValue = 0;
            try
            {
                int targetIndex = tile.GroupIndex;

                foreach (Tile item in Tiles)
                {
                    try
                    {
                        PurchasableTile temp = (item as PurchasableTile);

                        if(temp.GroupIndex == targetIndex && temp.Owner == player)
                        {
                            returnValue++;
                        }
                    }
                    catch { }
                }
            }
            catch { }

            return returnValue;
        }

        public List<PurchasableTile> GetTilesOfGroupIndex(int groupIndex)
        {
            List<PurchasableTile> returnValue = new List<PurchasableTile>();

            for (int i = 0; i < Tiles.Count; i++)
            {
                if (Tiles[i] is PurchasableTile)
                {
                    PurchasableTile temp = Tiles[i] as PurchasableTile;

                    if (temp.GroupIndex == groupIndex)
                    {
                        returnValue.Add(temp);
                    }
                }
            }

            return returnValue;
        }
        #endregion
    }
}
