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
        public Player() 
        {
            CanMove = true;
            IsAlive = true;
        }

        //The normal constructor for the player class for use in the game of Monopoly.
        public Player(int startBalance)
        {
            Balance = startBalance;
            CanMove = true;
            IsAlive = true;
        }
        #endregion

        #region Properties:

        //The balance is the amount of money the player currently have.
        public int Balance { get; set; }

        //Decides if the player can move or not. If it for example: can throw a dice and move.
        public bool CanMove { get; set; }

        //Indicates if the player can still play the game or has the player "been killed" / "lost" the game.
        public bool IsAlive { get; private set; }

        //This id will identify the player when for example: searching for it. Can be used as identifier.
        public int Id { get; set; }

        //Networth of the player (final):
        public int FinalNetworth { get; set; }
        #endregion

        #region Methods:
        //Simulates a player that throws a dice.
        public int[] Throw(params Dice[] globalDices)
        {
            List<int> returnValue = new List<int>();

            //Throws all the different dices and creates a list of all the values from the different dices.
            foreach (Dice item in globalDices)
            {
                returnValue.Add(item.Throw());
            }

            return returnValue.ToArray();
        }

        //Simulates a player that throws a tampered dice.
        public int[] TamperedThrow(params Dice[] globalDice)
        {
            throw new NotImplementedException();
        }

        //Sells the property to the bank.
        public void SellProperty(PurchasableTile tile)
        {
            this.Balance += tile.BaseCost;
            if (tile is Property)
            {
                Property prop = (tile as Property);

                this.Balance += prop.ConstructionCost * prop.HouseCount;

                prop.ChangeOwner(null);
            }
            else
            {
                tile.ChangeOwner(null);
            }
        }

        //Buys the property from the bank. The player can only buy the property they stand on.
        public void BuyProperty(PurchasableTile tile)
        {
            this.Balance -= tile.BaseCost;
            if(tile is Property)
            {
                (tile as Property).ChangeOwner(this);
            }
            else
            {
                tile.ChangeOwner(this);
            }
        }

        //This method will make it avaible to build on your properties.
        public bool BuildOnProperty(Property tile)
        {
            if(tile.Owner == this && tile.HouseCount < 5)
            {
                tile.HouseCount++;
                this.Balance -= tile.ConstructionCost;
                return true;
            }
            else { return false; }
        }

        //Will disable this player. Resigned players have "lost" and can't be apart of the game anymore.
        public void Resign()
        {
            IsAlive = false;
        }

        //Fetches all the tiles that are owned by the player.
        public List<PurchasableTile> GetOwnedTiles(List<Tile> tiles)
        {
            List<PurchasableTile> result = new List<PurchasableTile>();

            for (int i = 0; i < tiles.Count; i++)
            {
                if (tiles[i] is PurchasableTile)
                {
                    PurchasableTile temp = (tiles[i] as PurchasableTile);

                    if(temp.Owner == this as Player)
                    {
                        result.Add(temp);
                    }
                }
            }

            return result;
        }
        #endregion
    }
}
