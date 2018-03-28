using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class BlackJackCardGame : CardGame
    {
        public BlackjackHand DealerHand { get; set; }
        public BlackjackHand PlayerHand { get; set; }

        public override void Deal()
        {
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.CalculateTotal();

            DealerHand.Cards.Add(myDeck.GetCard());
            DealerHand.Cards.Add(myDeck.GetCard());
            DealerHand.CalculateTotal();

        }

        public override void DetermineWinner()
        {
            if (DealerHand.Total >= PlayerHand.Total) Winner = "Dealer";
            else Winner = "Player";
        }

        public void Hit()
        {
            PlayerHand.Cards.Add(myDeck.GetCard());
            PlayerHand.CalculateTotal();
        }

        public void Stand()
        {
            while ((DealerHand.Total <= 16) && (DealerHand.Cards.Count != 5))
            {
                //Deal the dealer a new card.
                DealerHand.Cards.Add(myDeck.GetCard());
            }

            DealerHand.CalculateTotal();
        }
    }
}
