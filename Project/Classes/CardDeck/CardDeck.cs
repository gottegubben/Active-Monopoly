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
        #endregion

        #region Methods:
        //This method will mix the cards in the deck.
        public void Shuffle()
        {
            Random random = new Random();

            for (int i = cards.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);

                Card value = cards[rnd];
                cards[rnd] = cards[i];
                cards[i] = value;
            }
        }
        #endregion

        //Ska innehålla en lista av kort
        //Blanda
        //Skicak ett kort och lägga det längst ner
    }
}
