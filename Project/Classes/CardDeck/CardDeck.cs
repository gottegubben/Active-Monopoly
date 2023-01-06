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
        #region Constuctors:
        public CardDeck()
        {
            Cards = new List<Card>();

            random = new Random();
        }

        public CardDeck(int seed)
        {
            Cards = new List<Card>();

            random = new Random(seed);
        }
        #endregion

        #region Properties:
        //The cards that exist in the deck.
        public List<Card> Cards { get; set; }

        //The random that will help with the shuffle of the deck.
        private Random random { get; set; }
        #endregion

        #region Methods:
        //This method will mix the cards in the deck.
        public void Shuffle()
        {
            for (int i = Cards.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                Card value = Cards[rnd];
                Cards[rnd] = Cards[i];
                Cards[i] = value;
            }
        }

        //Draw the card from the top of the deck and return it. At the same time, place the top card at the bottom.
        public Card DrawCard()
        {
            Card returnValue = Cards[0];

            Cards.Append(returnValue);

            Cards.RemoveAt(0);

            return returnValue;
        }
        #endregion
    }
}
