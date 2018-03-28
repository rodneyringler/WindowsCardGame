using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class PokerCardGame : CardGame
    {
        public PokerHand DealerHand { get; set; } = new PokerHand();
        public PokerHand PlayerHand { get; set; } = new PokerHand();


        public delegate void WeHaveAWinnnerDelegate(string winner);
         
        public event WeHaveAWinnnerDelegate WeHaveAWinner;

        public override void Deal()
        {
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.CalculateTotal();

            DealerHand.Cards.Add(myDeck.GetCard());
            DealerHand.Cards.Add(myDeck.GetCard());
            DealerHand.Cards.Add(myDeck.GetCard());
            DealerHand.Cards.Add(myDeck.GetCard());
            DealerHand.Cards.Add(myDeck.GetCard());
            DealerHand.CalculateTotal();

            DetermineWinner();
        }

        public override void DetermineWinner()
        {
            if (DealerHand.Total > PlayerHand.Total) Winner = "Dealer";
            else if (DealerHand.Total == PlayerHand.Total)
            {

            }
            else Winner = "Player";

            WeHaveAWinner(Winner);
        }
    }
}
