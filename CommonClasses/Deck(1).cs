using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class Deck
    {
        public static List<Card> Cards { get; set; }


        public void Initialize()
        {   
            Cards = new List<Card>();
            Cards.Add(new Card("Spades", "ace", 1, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\back.bmp"));
            Cards.Add(new Card("Spades", "two", 2, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s02.bmp"));
            Cards.Add(new Card("Spades", "three", 3, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s03.bmp"));
            Cards.Add(new Card("Spades", "four", 4, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s04.bmp"));
            Cards.Add(new Card("Spades", "five", 5, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s05.bmp"));
            Cards.Add(new Card("Spades", "six", 6, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s06.bmp"));
            Cards.Add(new Card("Spades", "seven", 7, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s07.bmp"));
            Cards.Add(new Card("Spades", "eight", 8, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s08.bmp"));
            Cards.Add(new Card("Spades", "nine", 9, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s09.bmp"));
            Cards.Add(new Card("Spades", "ten", 10, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s10.bmp"));
            Cards.Add(new Card("Spades", "jack", 11, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s11.bmp"));
            Cards.Add(new Card("Spades", "queen", 12, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s12.bmp"));
            Cards.Add(new Card("Spades", "king", 13, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\s13.bmp"));
            Cards.Add(new Card("Hearts", "ace", 1, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h01.bmp"));
            Cards.Add(new Card("Hearts", "two", 2, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h02.bmp"));
            Cards.Add(new Card("Hearts", "three", 3, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h03.bmp"));
            Cards.Add(new Card("Hearts", "four", 4, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h04.bmp"));
            Cards.Add(new Card("Hearts", "five", 5, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h05.bmp"));
            Cards.Add(new Card("Hearts", "six", 6, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h06.bmp"));
            Cards.Add(new Card("Hearts", "seven", 7, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h07.bmp"));
            Cards.Add(new Card("Hearts", "eight", 8, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h08.bmp"));
            Cards.Add(new Card("Hearts", "nine", 9, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h09.bmp"));
            Cards.Add(new Card("Hearts", "ten", 10, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h10.bmp"));
            Cards.Add(new Card("Hearts", "jack", 11, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h11.bmp"));
            Cards.Add(new Card("Hearts", "queen", 12, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h12.bmp"));
            Cards.Add(new Card("Hearts", "king", 13, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\h13.bmp"));
            Cards.Add(new Card("Diamonds", "ace", 1, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d01.bmp"));
            Cards.Add(new Card("Diamonds", "two", 2, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d02.bmp"));
            Cards.Add(new Card("Diamonds", "three", 3, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d03.bmp"));
            Cards.Add(new Card("Diamonds", "four", 4, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d04.bmp"));
            Cards.Add(new Card("Diamonds", "five", 5, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d05.bmp"));
            Cards.Add(new Card("Diamonds", "six", 6, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d06.bmp"));
            Cards.Add(new Card("Diamonds", "seven", 7, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d07.bmp"));
            Cards.Add(new Card("Diamonds", "eight", 8, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d08.bmp"));
            Cards.Add(new Card("Diamonds", "nine", 9, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d09.bmp"));
            Cards.Add(new Card("Diamonds", "ten", 10, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d10.bmp"));
            Cards.Add(new Card("Diamonds", "jack", 11, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d11.bmp"));
            Cards.Add(new Card("Diamonds", "queen", 12, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d12.bmp"));
            Cards.Add(new Card("Diamonds", "king", 13, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\d13.bmp"));
            Cards.Add(new Card("Clubs", "ace", 1, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c01.bmp"));
            Cards.Add(new Card("Clubs", "two", 2, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c02.bmp"));
            Cards.Add(new Card("Cllubs", "three", 3, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c03.bmp"));
            Cards.Add(new Card("Clubs", "four", 4, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c04.bmp"));
            Cards.Add(new Card("Clubs", "five", 5, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c05.bmp"));
            Cards.Add(new Card("Clubs", "six", 6, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c06.bmp"));
            Cards.Add(new Card("Clubs", "seven", 7, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c07.bmp"));
            Cards.Add(new Card("Clubs", "eight", 8, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c08.bmp"));
            Cards.Add(new Card("Clubs", "nine", 9, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c09.bmp"));
            Cards.Add(new Card("Clubs", "ten", 10, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c10.bmp"));
            Cards.Add(new Card("Clubs", "jack", 11, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c11.bmp"));
            Cards.Add(new Card("Clubs", "queen", 12, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c12.bmp"));
            Cards.Add(new Card("Clubs", "king", 13, false, false, "C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\CardGame\\Resources\\c13.bmp"));
        }

        


        public Card GetCard()
        {
            int x;
            Card c;
            Random r = new Random();
            do
            {
                x = r.Next(1, Cards.Count);
                c = Cards[x]; //next card
            }
            while (c.Dealt == true);

            Cards[x].Dealt = true; //next card

            return c;
        }

    }
}