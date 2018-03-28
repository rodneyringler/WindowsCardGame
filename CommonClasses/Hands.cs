using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Hands
    {
        private List<Card> hand = new List<Card>();
        public List<Card> Hand;

        private int total;
        public int Total;


        public int CalculateTotal()
        {
            Total = 0;

            foreach (Card c in Hand)
            {
                Total += c.NumberValue;
            }

            return Total;
        }

    }
}