using System.Collections.Generic;

namespace CommonClasses
{
    public abstract class Hand
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public int Total { get; set; }

        public string Rank { get; set; }

        public abstract void CalculateTotal();
    }
}