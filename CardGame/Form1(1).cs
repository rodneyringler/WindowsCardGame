using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClasses;
using System.Data.SqlClient;

namespace CardGame
{
    public partial class Form1 : Form
    {
        public Deck myDeck = new Deck();

        public Form1()
        {
            InitializeComponent();

            myDeck.Initialize();
        }


        private void btnGetCard_Click(object sender, EventArgs e)
        {
            Card card = myDeck.GetCard();
            {
                if (tbCard5FaceValue.Text == "")
                {
                    tbCard5Suit.Text = card.Suit;
                    tbCard5FaceValue.Text = card.FaceValue;
                    tbCard5NumberValue.Text = card.NumberValue.ToString();
                    card.FaceUp = true;
                    Bitmap bmCard5 = new Bitmap(card.Image);
                    pictureBoxCard5.Image = bmCard5;

                    Hands.PlayerHand.Add(card);
                    Hands.PlayerTotal += card.NumberValue;
                    labelPlayerTotalNum.Text = Convert.ToString(Hands.PlayerTotal);
                    
                    //check for bust and BlackJack, compare hands
                    Rules rules = new Rules();
                    if (rules.CheckForBust(Hands.PlayerHand) == true)
                    {
                        labelGameResult.Text = "Sorry, you bust. Play again.";
                    }
                    else if (rules.CheckForBlackJack(Hands.PlayerHand))
                    {
                        labelGameResult.Text = "Black Jack!! Congratulations, you win! Play again.";
                    }
                    else if (rules.CompareHands() == 1)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                }

                else if (tbCard7FaceValue.Text == "")
                {
                    tbCard7Suit.Text = card.Suit;
                    tbCard7FaceValue.Text = card.FaceValue;
                    tbCard7NumberValue.Text = card.NumberValue.ToString();
                    card.FaceUp = true;
                    Bitmap bmCard7 = new Bitmap(card.Image);
                    pictureBoxCard7.Image = bmCard7;

                    Hands.PlayerTotal += card.NumberValue;
                    labelPlayerTotalNum.Text = Convert.ToString(Hands.PlayerTotal);
                    
                    //check for bust and BlackJack, compare hands
                    Rules rules = new Rules();
                    if (rules.CheckForBust(Hands.PlayerHand) == true)
                    {
                        labelGameResult.Text = "Sorry, you bust. Play again.";
                    }
                    else if (rules.CheckForBlackJack(Hands.PlayerHand))
                    {
                        labelGameResult.Text = "Black Jack!! Congratulations, you win! Play again.";
                    }
                    else if (rules.CompareHands() == 1)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                }
                else if (tbCard9FaceValue.Text == "")
                {
                    tbCard9Suit.Text = card.Suit;
                    tbCard9FaceValue.Text = card.FaceValue;
                    tbCard9NumberValue.Text = card.NumberValue.ToString();
                    card.FaceUp = true;Bitmap bmCard9 = new Bitmap(card.Image);
                    pictureBoxCard9.Image = bmCard9;
                    
                    Hands.PlayerTotal += card.NumberValue;
                    labelPlayerTotalNum.Text = Convert.ToString(Hands.PlayerTotal);
                    
                    //check for bust and BlackJack, compare hands
                    Rules rules = new Rules();
                    if (rules.CheckForBust(Hands.PlayerHand) == true)
                    {
                        labelGameResult.Text = "Sorry, you bust. Play again.";
                    }
                    else if (rules.CheckForBlackJack(Hands.PlayerHand))
                    {
                        labelGameResult.Text = "Black Jack!! Congratulations, you win! Play again.";
                    }
                    else if (rules.CompareHands() == 1)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                }
            }
            }


        private void btnStand_Click(object sender, EventArgs e)
        {
            Card card = myDeck.GetCard();
            {
                if (tbCard4FaceValue.Text == "")
                {
                    tbCard4Suit.Text = card.Suit;
                    tbCard4FaceValue.Text = card.FaceValue;
                    tbCard4NumberValue.Text = card.NumberValue.ToString();
                    card.FaceUp = true;
                    Bitmap bmCard4 = new Bitmap(card.Image);
                    pictureBoxCard4.Image = bmCard4;

                    Hands.PlayerTotal += card.NumberValue;
                    labelPlayerTotalNum.Text = Convert.ToString(Hands.PlayerTotal);

                    //check for bust and BlackJack, compare hands
                    Rules rules = new Rules();
                    if (rules.CheckForBust(Hands.DealerHand) == true)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                    else if (rules.CheckForBlackJack(Hands.DealerHand))
                    {
                        labelGameResult.Text = "Dealer Black Jack. Sorry, you lose. Play again.";
                    }
                    else if (rules.CompareHands() == 1)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                }

                else if (tbCard6FaceValue.Text == "")
                {
                    tbCard6Suit.Text = card.Suit;
                    tbCard6FaceValue.Text = card.FaceValue;
                    tbCard6NumberValue.Text = card.NumberValue.ToString();
                    card.FaceUp = true;
                    Bitmap bmCard6 = new Bitmap(card.Image);
                    pictureBoxCard6.Image = bmCard6;

                    Hands.DealerTotal += card.NumberValue;
                    labelPlayerTotalNum.Text = Convert.ToString(Hands.DealerTotal);

                    //check for bust and BlackJack, compare hands
                    Rules rules = new Rules();
                    if (rules.CheckForBust(Hands.DealerHand) == true)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                    else if (rules.CheckForBlackJack(Hands.DealerHand))
                    {
                        labelGameResult.Text = "Dealer Black Jack. Sorry, you lose. Play again.";
                    }
                    else if (rules.CompareHands() == 1)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                }
                else if (tbCard8FaceValue.Text == "")
                {
                    tbCard8Suit.Text = card.Suit;
                    tbCard8FaceValue.Text = card.FaceValue;
                    tbCard8NumberValue.Text = card.NumberValue.ToString();
                    card.FaceUp = true;
                    Bitmap bmCard8 = new Bitmap(card.Image);
                    pictureBoxCard8.Image = bmCard8;

                    Hands.DealerTotal += card.NumberValue;
                    labelDealerTotalNum.Text = Convert.ToString(Hands.DealerTotal);

                    //check for bust and BlackJack, compare hands
                    Rules rules = new Rules();
                    if (rules.CheckForBust(Hands.DealerHand) == true)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                    else if (rules.CheckForBlackJack(Hands.DealerHand))
                    {
                        labelGameResult.Text = "Dealer Black Jack. Sorry, you lose. Play again.";
                    }
                    else if (rules.CompareHands() == 1)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                }
                else if (tbCard10FaceValue.Text == "")
                {
                    tbCard10Suit.Text = card.Suit;
                    tbCard10FaceValue.Text = card.FaceValue;
                    tbCard10NumberValue.Text = card.NumberValue.ToString();
                    card.FaceUp = true;
                    Bitmap bmCard10 = new Bitmap(card.Image);
                    pictureBoxCard10.Image = bmCard10;

                    Hands.DealerTotal += card.NumberValue;
                    labelDealerTotalNum.Text = Convert.ToString(Hands.DealerTotal);

                    //check for bust and BlackJack, compare hands
                    Rules rules = new Rules();
                    if (rules.CheckForBust(Hands.DealerHand) == true)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                    else if (rules.CheckForBlackJack(Hands.DealerHand))
                    {
                        labelGameResult.Text = "Dealer Black Jack. Sorry, you lose. Play again.";
                    }
                    else if (rules.CompareHands() == 1)
                    {
                        labelGameResult.Text = "Congratulations, you win! Play again.";
                    }
                }
                //fill table
                string connectionString = @"Data Source=184.168.47.17;Initial Catalog=csharpexpert_users;Persist Security Info=True;User ID=reachit;Password=reachit01!";
                SqlConnection connection = new SqlConnection(connectionString);
                string gameResultCommandText = "SELECT * FROM GameResult WHERE Player = 'David'";
                SqlCommand cmd = new SqlCommand(gameResultCommandText, connection);
                SqlDataAdapter gameResultAdapter = new SqlDataAdapter(gameResultCommandText, connection);
                DataTable dt = new DataTable();
                gameResultAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void btnDeal_Click(object sender, EventArgs e)
        {
            Card card1 = myDeck.GetCard();
            Card card2 = myDeck.GetCard();
            Card card3 = myDeck.GetCard();

            List<Card> dealtPlayerHand = new List<Card>();
            List<Card> dealtDealerHand = new List<Card>();

            //Deal cards
            Hands.PlayerTotal += card1.NumberValue;
            Hands.PlayerTotal += card3.NumberValue;
            dealtPlayerHand.Add(card1);
            tbCard1FaceValue.Text = card1.FaceValue;
            tbCard1NumberValue.Text = card1.NumberValue.ToString();
            tbCard1Suit.Text = card1.Suit;
            card1.FaceUp = true;
            card1.Dealt = true;
            Bitmap bmCard1 = new Bitmap(card1.Image);
            pictureBoxCard1.Image = bmCard1;

            Hands.DealerTotal += card2.NumberValue;
            dealtDealerHand.Add(card2);
            tbCard2FaceValue.Text = card2.FaceValue;
            tbCard2NumberValue.Text = card2.NumberValue.ToString();
            tbCard2Suit.Text = card2.Suit;
            card2.FaceUp = false;
            card2.Dealt = true;
            Bitmap bmCard2 = new Bitmap(card2.Image);
            pictureBoxCard2.Image = bmCard2;

            dealtPlayerHand.Add(card3);
            tbCard3FaceValue.Text = card3.FaceValue;
            tbCard3NumberValue.Text = card3.NumberValue.ToString();
            tbCard3Suit.Text = card3.Suit;
            card3.FaceUp = true;
            card3.Dealt = true;
            Bitmap bmCard3 = new Bitmap(card3.Image);
            pictureBoxCard3.Image = bmCard3;

            // Card 4 is special case- not dealt by program until stand
            tbCard4FaceValue.Text = null;
            tbCard4NumberValue.Text = null;
            tbCard4Suit.Text = null;
            Bitmap bmCard4 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
            pictureBoxCard4.Image = bmCard4;

            //Display only value of Card 2 on DealerTotalLabel upon deal
            string temp = card2.NumberValue.ToString();
            labelDealerTotalNum.Text = temp;

            //Check Player Hand- calculate total and check for BlackJack and busts after deal
            Hands.PlayerTotal = card1.NumberValue + card3.NumberValue;
            labelPlayerTotalNum.Text = Convert.ToString(Hands.PlayerTotal);

            //check for player bust
            Rules rulesBust = new Rules();
            if (rulesBust.CheckForBust(dealtPlayerHand) == true)
            {
                labelGameResult.Text = "Sorry, you bust. Play again.";
            }

            //check for player blackjack
            Rules rulesBlackJack = new Rules();
            if (rulesBlackJack.CheckForBlackJack(dealtPlayerHand) == true)
            {
                labelGameResult.Text = "BlackJack!! Congratulations! You win! Play again.";
            }
            
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
        myDeck.Initialize();
        
        labelGameResult.Text = "Game Result";
        labelDealerTotalNum.Text = "0";
        labelPlayerTotalNum.Text = "0";

        //Reset all text boxes and cards
        tbCard1FaceValue.Text = null;
        tbCard1NumberValue.Text = null;
        tbCard1Suit.Text = null;
        tbCard1FaceValue.Text = null;
        tbCard1NumberValue.Text = null;
        Bitmap bmCard1 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard1.Image = bmCard1;

        tbCard2FaceValue.Text = null;
        tbCard2NumberValue.Text = null;
        tbCard2Suit.Text = null;
        Bitmap bmCard2 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard2.Image = bmCard2;

        tbCard3FaceValue.Text = null;
        tbCard3NumberValue.Text = null;
        tbCard3Suit.Text = null;
        Bitmap bmCard3 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard3.Image = bmCard3;

        tbCard4FaceValue.Text = null;
        tbCard4NumberValue.Text = null;
        tbCard4Suit.Text = null;
        Bitmap bmCard4 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard4.Image = bmCard4;

        tbCard5FaceValue.Text = null;
        tbCard5NumberValue.Text = null;
        tbCard5Suit.Text = null;
        Bitmap bmCard5 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard5.Image = bmCard5;

        tbCard6FaceValue.Text = null;
        tbCard6NumberValue.Text = null;
        tbCard6Suit.Text = null;
        Bitmap bmCard6 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard6.Image = bmCard6;

        tbCard7FaceValue.Text = null;
        tbCard7NumberValue.Text = null;
        tbCard7Suit.Text = null;
        Bitmap bmCard7 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard7.Image = bmCard7;

        tbCard8FaceValue.Text = null;
        tbCard8NumberValue.Text = null;
        tbCard8Suit.Text = null;
        Bitmap bmCard8 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard8.Image = bmCard8;

        tbCard9FaceValue.Text = null;
        tbCard9NumberValue.Text = null;
        tbCard9Suit.Text = null;
        Bitmap bmCard9 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard9.Image = bmCard9;

        tbCard10FaceValue.Text = null;
        tbCard10NumberValue.Text = null;
        tbCard10Suit.Text = null;
        Bitmap bmCard10 = new Bitmap("C:\\Users\\David\\Documents\\Visual Studio 2013\\Projects\\Dev\\CardGame\\card-BMPs\\back.bmp");
        pictureBoxCard10.Image = bmCard10;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}