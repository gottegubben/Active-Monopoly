using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This class is a card that can be picked up by the player.
    /// </summary>
    public class Card
    {
        #region Constructors:
        //Takes an action that the player will perform. The Player class will be the parameter for this type of method.
        public Card(Action<Player, GameData> action)
        {
            Action = action;
        }

        public Card(string message, Action<Player, GameData> action)
        {
            Message = message;

            Action = action;
        }
        #endregion

        #region Properties:
        //The message on the card.
        public string Message { get; set; }

        //The action that the card will perform. Will be the function that is presented in the constuctor.
        Action<Player, GameData> Action { get; set; }
        #endregion

        #region Methods:
        public void PerformAction(Player player, GameData data) //Maybe need a callback variable for the game.
        {
            Action.Invoke(player, data);

            //Send stats to the statistic center.
        }
        #endregion
    }
}
