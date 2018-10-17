using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    
    class deck
    {
        private List<int> cardDeck = new List<int>();

        public deck(List<int> cardDeck)
        {
            this.cardDeck = cardDeck;
        }
    }
}
