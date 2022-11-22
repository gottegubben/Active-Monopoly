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
        //All the tiles that will be used in the game and in there respected order.
        public List<Tile> Tiles { get; }
        
        //All the players that will be playing the game. Can be a minimum of two players.
        public List<Player> Players { get; }

        //The dices that will be used in the game.
        public List<Dice> Dices { get; }

        //The action handler for the game.
        public ActionHandler ActionHandler { get; }
        #endregion
    }
}