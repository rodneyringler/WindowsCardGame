using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Card
    {
        public string Suit { get; set; }
        public string FaceValue { get; set; }
        public int NumberValue { get; set; }
        public bool Dealt { get; set; }
        public bool FaceUp { get; set; }
        public string Image { get; set; }

        public Card(string suit, string facevalue, int numbervalue, bool dealt, bool faceup, string imageLocation)
        {
            Suit = suit;
            FaceValue = facevalue;
            NumberValue = numbervalue;
            Dealt = dealt;
            FaceUp = faceup;
            Image = imageLocation;
        }
    }
}