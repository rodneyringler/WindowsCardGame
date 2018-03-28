using System;
using System.Collections.Generic;


namespace CommonClasses
{
    public class Deck
    {
        private Random r = new Random();

        public List<Card> Cards { get; set; } = new List<Card>();


        public void Initialize()
        {   
            string[] suit = new string[4] {"club", "diamond", "heart", "spade"};
            string[] rank = new string[13] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "j", "q", "k", "a"};

            //Clear the cards first.
            Cards.Clear();

            for (int j = 0; j < 4; j++)
            {
                string currentsuit = suit[j];

                for (int i = 0; i <= 12; i++)
                {
                    //Calculate the number value of the card.
                    int numvalue = 0;

                    if (i < 9)
                    {
                        numvalue = i + 2;
                    }
                    else if (i > 11)
                    {
                        numvalue = 11;
                    }
                    else
                    {
                        numvalue = 10;
                    }
                    //Add the card to the deck.
                    string imagename = @"CardImages\" + rank[i] + currentsuit.Substring(0, 1) + ".png";
                    Cards.Add(new Card(currentsuit, rank[i], numvalue, false, false, imagename, i+1));
                }
            }
         }

        public Card GetCard()
        {
            int randomnumber;
            Card c;

            randomnumber = r.Next(0, Cards.Count);

            c = Cards[randomnumber];
            c.Dealt = true;
            
            //remove from deck.
            Cards.RemoveAt(randomnumber);

            
            return c;
        }

    }
}