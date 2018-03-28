using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Rules
    {
        protected int Winner { get; set; }
        protected Boolean PlayerWins;


        // deal and stand buttons
        public Boolean CheckForBust(List<Card> hand)
        {
            Boolean bust;
            int handTotal = 0;

            foreach (Card c in hand)
            {
                handTotal += c.NumberValue;
            }
            if (handTotal > 21)
            {
                bust = true;
            }
            else
            {
                bust = false;
            }
            return bust;
        }


        public Boolean CheckForBlackJack(List<Card> hand)
        {
            Boolean blackjack;
            int handTotal = 0;

            foreach (Card c in hand)
            {
                handTotal += c.NumberValue;
            }


            if (handTotal == 21)
            {
                //FIXME!
                //Array[] handsArray = new Array[2];
                //handsArray.ToArray();

                //if ((handsArray[0].NumberValue == 11 || 12 || 13) &&
                //        (handsArray[1].NumberValue == 1)) |
                //        ((handsArray[1].NumberValue == 11 | 12 | 13) &&
                //        (handsArray[0].NumberValue == 1)))
                blackjack = true;
                return blackjack;
            }
            else
            {
                return false;
            }
        }

        public int CompareHands()
        {
            if (Hands.PlayerTotal < Hands.DealerTotal)
            {
                return 1;//player wins
            }
            else
            {
                return 0;//dealer wins
            }


            //turn over dealer cards sequentially


            //check for dealer black jack

            //compare player and dealer totals

        }


        //rules for first four cards

        //check for dealer <= 16, 21, etc.

        //rules for remaining cards








        //    if  ((((Convert.ToInt32(tbCard1NumberValue))
        //        +(Convert.ToInt32(tbCard2NumberValue)))

        //        <=21)

        //        &&

        //        (((Convert.ToInt32(tbCard1NumberValue))
        //        +
        //        (Convert.ToInt32(tbCard2NumberValue)))

        //        >

        //        (((Convert.ToInt32(tbCard3NumberValue)) +
        //        (Convert.ToInt32(tbCard4NumberValue)) +
        //        (Convert.ToInt32(tbCard5NumberValue))))))

        //    {
        //        labelGameResult.Text = "Sorry, you lose. Play again.";
        //    }
        //    else if ()
        //    {
        //        labelGameResult.Text = "Congratulations! You Win!";
        //    }

        
    }
}

