﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The boardgame class is for controlling the board of the game of Monopoly.
    /// </summary>
    public class Game
    {
        #region Properties
        //The initial data. The players, the dices and the tiles.
        public GameData Data { get; }
        #endregion

        #region Methods:
        //Starts the match.
        public void StartMatch() { GameLoop(); }

        //The main loop that will run the game.
        private void GameLoop()
        {

        }
        #endregion
    }
}