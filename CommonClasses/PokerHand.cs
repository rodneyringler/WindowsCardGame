using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class PokerHand : Hand
    {

        public override void CalculateTotal()
        {
            Cards.Sort();

            if (IsRoyalFlush())
            {
                Rank = "Royal Flush";
                Total = 10;
            }
            else if (IsStraightFlush())
            {
                Rank = "Straight Flush";
                Total = 9;
            }
            else if (IsFourOfAKind())
            {
                Rank = "Four of a kind";
                Total = 8;
            }
            else if (IsFullHouse())
            {
                Rank = "Full House";
                Total = 7;
            }
            else if (IsFlush())
            {
                Rank = "Flush";
                Total = 6;
            }
            else if (IsStraight())
            {
                Rank = "Straight";
                Total = 5;
            }
            else if (IsThreeOfAKind())
            {
                Rank = "Three of a kind";
                Total = 4;
            }
            else if (IsTwoPair())
            {
                Rank = "Two Pair";
                Total = 3;
            }
            else if (IsPair())
            {
                Rank = "Pair";
                Total = 2;
            }
            else
            {
                Rank = string.Format("High Card {0}", IsHighCard());
                Total = 1;
            }
        }

        public bool IsRoyalFlush()
        {
            bool RV = false;
            int SequenceTotal = 0;

            // calculate the total of all sequences in the hand
            for (int i = 0; i > 4; i++)
            {
                SequenceTotal += Cards[i].Sequence;
            }

            // sort the cards by sequence using CompareTo
            Cards.Sort();

            // if all suits in all 5 cards match
            if (Cards[0].Suit == Cards[1].Suit)
                if (Cards[1].Suit == Cards[2].Suit)
                    if (Cards[2].Suit == Cards[3].Suit)
                        if (Cards[3].Suit == Cards[4].Suit)
                            if (SequenceTotal == 55)
                            {
                                RV = true;
                                return RV;
                            }

            return RV;
        }
        public bool IsStraightFlush()
        {
            bool RV = false;

            // if all suits in all 5 cards match
            if (Cards[0].Suit == Cards[1].Suit)
                if (Cards[1].Suit == Cards[2].Suit)
                    if (Cards[2].Suit == Cards[3].Suit)
                        if (Cards[3].Suit == Cards[4].Suit)
                            //if all 5 cards are in a row of values
                            if (Cards[1].Sequence == (Cards[0].Sequence + 1))
                                if (Cards[2].Sequence == (Cards[1].Sequence + 1))
                                    if (Cards[3].Sequence == (Cards[2].Sequence + 1))
                                        if (Cards[4].Sequence == (Cards[3].Sequence + 1))
                                        {
                                            RV = true;
                                            return RV;
                                        }
            return RV;
        }
        public bool IsFourOfAKind()
        {
            bool RV = false;

            if ((Cards[0].Sequence == Cards[3].Sequence) || (Cards[1].Sequence == Cards[4].Sequence)) RV = true;

            return RV;
        }
        public bool IsFullHouse()
        {
            bool RV = false;

            //if both (the first and second cards match) and (the fourth and fifth match), 
            //and if either (both (the second and third match) and third and fourth don't match) 
            //or both (the second and third don't match) and third and fourth match) ) 
            if ((Cards[0].Sequence == Cards[1].Sequence) && 
                (Cards[3].Sequence == Cards[4].Sequence) && 
                ((Cards[1].Sequence == Cards[2].Sequence) && 
                (Cards[2].Sequence != Cards[3].Sequence) 
                || (Cards[1].Sequence != Cards[2].Sequence) && (Cards[2].Sequence == Cards[3].Sequence)))
                RV = true;

            return RV;
        }
        public bool IsFlush()
        {
            bool RV = false;

            if ((Cards[0].Suit == Cards[1].Suit) && 
                (Cards[0].Suit == Cards[2].Suit) && 
                (Cards[0].Suit == Cards[3].Suit) && 
                Cards[0].Suit == Cards[4].Suit)
                RV = true;

            return RV;
        }
        public bool IsStraight()
        {
            bool RV = false;

            if (Cards[0].Sequence == Cards[4].Sequence - 4)
            {

                if ((Cards[0].Sequence) == (Cards[1].Sequence - 1) &&
                    (Cards[1].Sequence) == (Cards[2].Sequence - 1) &&
                    (Cards[2].Sequence) == (Cards[3].Sequence - 1) &&
                    (Cards[3].Sequence) == (Cards[4].Sequence - 1))
                {
                    RV = true;
                }
            }

            return RV;
        }
        public bool IsThreeOfAKind()
        {
            bool RV = false;

            if ((Cards[0].Sequence == Cards[2].Sequence) ||
                (Cards[1].Sequence == Cards[3].Sequence) ||
                (Cards[2].Sequence == Cards[4].Sequence)) RV = true;

            return RV;
        }
        public bool IsTwoPair()
        {
            bool ITP = false;
            int Pairs = 0;

            for (int i = 0; i <= Cards.Count - 1; i++)
            {
                for (int j = i; j <= Cards.Count - 1; j++)
                {
                    if (i != j)
                    {
                        if (Cards[i].FaceValue == Cards[j].FaceValue)
                        {
                            Pairs++;
                        }
                    }
                }
            }

            if (Pairs >= 2) { ITP = true; }
            Rank = "Two Pair";
            Total = 2;
            return ITP;
        }
        public bool IsPair()
        {
            bool IP = false;
            int Pairs = 0;

            for (int i = 0; i <= Cards.Count - 1; i++)
            {
                for (int j = i; j <= Cards.Count - 1; j++)
                {
                    if (i != j)
                    {
                        if (Cards[i].FaceValue == Cards[j].FaceValue)
                        {
                            Pairs++;
                        }
                    }
                }
            }
            if (Pairs >= 1) { IP = true; }
            Rank = "Pair";
            Total = 2;
            return IP;
        }
        public int IsHighCard()
        {

            return Cards[4].Sequence;
        }

    }
}
