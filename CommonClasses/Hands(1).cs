using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Hands
    {
        public static List<Card> DealerHand;
        public static List<Card> PlayerHand;

        public static double PlayerTotal;
        public static double DealerTotal;

        public static double CalculatePlayerTotal(List<Card> playerHand)
        {
            List<Card> PlayerHand = new List<Card>();
            foreach (Card c in PlayerHand)
            {
                PlayerTotal += c.NumberValue;
            }
            return PlayerTotal;
        }

        public static double CalculateDealerTotal(List<Card> dealerHand)
        {
            List<Card> DealerHand = new List<Card>();
            foreach (Card c in DealerHand)
            {
                DealerTotal += c.NumberValue;
            }
            return DealerTotal;
        }

        //public int CalculatePlayerTotal(int card1NumValue, int card3NumValue, int card5NumValue, int card7NumValue, int card9NumValue)
        //{
        //    PlayerTotal =
        //        card1NumValue +
        //        card3NumValue +
        //        card5NumValue +
        //        card7NumValue +
        //        card9NumValue;
        //    return PlayerTotal;
        //}


        //public int CalculateDealerTotal(int card2NumValue, int card4NumValue, int card6NumValue, int card8NumValue, int card10NumValue)
        //{
        //    DealerTotal =
        //        card2NumValue +
        //        card4NumValue +
        //        card6NumValue +
        //        card8NumValue +
        //        card10NumValue;
        //    return DealerTotal;
        //}
    }
}