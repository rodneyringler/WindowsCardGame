using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public abstract class CardGame
    {
        public Deck myDeck = new Deck();
        public String Winner { get; set; }

        public CardGame()
        {
            myDeck.Initialize();
        }

        public abstract void DetermineWinner();

        public abstract void Deal();
    }
}
