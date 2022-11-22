using System;
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
        #region Constructors:
        //This constructor will work as a dummy for different kinds of simulations that doesn't need the other properties that the player class have.
        public Player() { }

        //The normal constructor for the player class for use in the game of Monopoly.
        public Player(int startBalance)
        {
            Balance = startBalance;
        }
        #endregion

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
        public int[] Throw(params Dice[] globalDices)
        {
            if (CanMove)
            {
                List<int> returnValue = new List<int>();

                //Throws all the different dices and creates a list of all the values from the different dices.
                foreach (Dice item in globalDices)
                {
                    returnValue.Add(item.Throw());
                }

                return returnValue.ToArray();
            }
            else
            {
                return null;
            }
        }

        //Simulates a player that throws a tampered dice.
        public int[] TamperedThrow(params Dice[] globalDice)
        {
            throw new NotImplementedException();
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

        //This method will make it avaible to build on your properties.
        public void BuildOnProperty()
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
