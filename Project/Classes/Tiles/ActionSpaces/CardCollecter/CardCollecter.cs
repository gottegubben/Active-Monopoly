using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The card collector class will represent a tile that when stepped on, will pick up a card of a certain type for the player to apply in the game.
    /// </summary>
    public class CardCollecter : ActionSpace
    {
        #region Constructors:
        //This constructor have a card type parameter to show what type of card should be picked up by this card collector.
        public CardCollecter(CardType cardType) 
        {
            this.cardType = cardType;
        }
        #endregion

        #region Properties:
        //The card type is the type of card that the card collecter is going to pick up.
        private CardType cardType { get; }

        public CardDeck CardDeck { get; set; }
        #endregion

        #region Methods:
        //The action will pick up a card and the player will apply that card.
        public override void Action(Player player, GameData data)
        {
            PerformActionCallbackRef?.Invoke(player, data, CardDeck, TypeOfAction.PickUpCard);
        }
        #endregion
    }
}
