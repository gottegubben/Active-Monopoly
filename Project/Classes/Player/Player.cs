﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The player class contains all the different actions that the player can make while playing monopoly.
    /// </summary>
    public class Player
    {
        #region Properties:

        //The balance is the amount of money the player currently have.
        public int Balance { get; private set; }

        //Decides if the player can move or not. If it for example: can throw a dice and move.
        public bool CanMove { get; private set; }

        //Indicates if the player can still play the game or has the player "been killed" / "lost" the game.
        public bool IsAlive { get; private set; }
        #endregion

        #region Methods:
        //Simulates a player that throws a dice.
        public int Throw(Dice globalDice)
        {
            if (CanMove)
            {
                return globalDice.Throw();
            }
            else { return 0; }
        }

        //Simulates a player that throws a tampered dice.
        public int TamperedThrow(Dice globalDice)
        {
            if (CanMove)
            {
                return globalDice.TamperedThrow();
            }
            else { return 0; }
        }

        //Sells the property to the bank.
        public void SellProperty()
        {
            throw new NotImplementedException();
        }

        //Buys the property from the bank.
        public void BuyProperty()
        {
            throw new NotImplementedException();
        }

        //Will disable this player. Resigned players have "lost" and can't be apart of the game anymore.
        public void Resign()
        {
            IsAlive = false;
        }
        #endregion
    }
}
