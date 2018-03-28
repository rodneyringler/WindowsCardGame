
using System;

namespace CommonClasses
{
    public class Card : IComparable
    {
        public string Suit { get; set; }
        public string FaceValue { get; set; }
        public int NumberValue { get; set; }
        public bool Dealt { get; set; }
        public bool FaceUp { get; set; }
        public string Image { get; set; }
        public int Sequence { get; set; }

        public Card(string suit, string facevalue, int numbervalue, bool dealt, bool faceup, string imageLocation, int sequence)
        {
            Suit = suit;
            FaceValue = facevalue;
            NumberValue = numbervalue;
            Dealt = dealt;
            FaceUp = faceup;
            Image = imageLocation;
            Sequence = sequence;
            
        }

        public int CompareTo(Object o)
        {
            Card C = (Card)o;
            int RV = 0;

            if (this.Sequence > C.Sequence) RV = 1;
            else if (this.Sequence < C.Sequence) RV = -1;

            return RV;
        }

        public bool IsAce()
        {
            bool ace = false;

            if (NumberValue == 11) ace = true;

            return ace;
        }
    }
}