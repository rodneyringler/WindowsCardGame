using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class BlackjackHand : Hand
    {

        public override void CalculateTotal()
        {

            Total = 0;

            foreach (Card c in Cards)
            {
                Total += c.NumberValue;
            }

            if (Total > 21)
            {
                Total = 0;

                foreach (Card c in Cards)
                {
                    if (c.IsAce()) c.NumberValue = 1;

                    Total += c.NumberValue;
                }
            }
        }

    }
}
