using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The card deck class will represent a card deck on the table. It can either be the "community chest - cards" or the "chance - cards".
    /// </summary>
    public class CardDeck
    {
        #region Properties:
        //The cards that exist in the deck.
        private List<Card> cards { get; set; }

        private Random random { get; set; }
        #endregion

        #region Methods:
        //This method will mix the cards in the deck.
        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                Card value = cards[rnd];
                cards[rnd] = cards[i];
                cards[i] = value;
            }
        }

        //Draw the card from the top of the deck and return it. At the same time, place the top card at the bottom.
        public Card DrawCard()
        {
            Card returnValue = cards[0];

            cards.Append(returnValue);

            cards.RemoveAt(0);

            return returnValue;
        }
        #endregion
    }
}
