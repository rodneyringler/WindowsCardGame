using System;
using System.Windows.Forms;
using CommonClasses;
using System.IO;

namespace CardGame
{
    public partial class Form1 : Form
    {

        #region Fields

        Deck myDeck = new Deck();
        Hand PlayerHand = new BlackjackHand();
        Hand DealerHand = new BlackjackHand();
        GameResults Results = new GameResults("log.txt");

        #endregion Fields

        #region Constructors

        public Form1()
        {
            try
            {
                InitializeComponent();

                //initialize new deck.
                myDeck.Initialize();

                //Setup for a new game.
                NewGame();

                //Populate results.
                foreach(GameResult GR in Results.Results)
                {
                    lbResults.Items.Add(string.Format("Winner is {0}. Score is D - {1}, P = {2}", GR.Winner, GR.DealerScore, GR.PlayerScore));
                }

                tbDealerWins.Text = Results.NumberOfDealerWins.ToString();
                tbPlayerWins.Text = Results.NumberOfPlayerWins.ToString();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        #endregion Constructors

        #region Event Handlers

        private void btnHit_Click(object sender, EventArgs e)
        {
            try
            {
                //Add another card to the hand.
                PlayerHand.Cards.Add(myDeck.GetCard());

                //Update the hand's total.
                PlayerHand.CalculateTotal();

                //Display the new hand total.
                tbPTotal.Text = PlayerHand.Total.ToString();

                //Figure out which card was dealt and display that card.
                if (PlayerHand.Cards.Count == 3)
                {
                    pbPCard3.ImageLocation = PlayerHand.Cards[2].Image;
                    pbPCard3.Visible = true;

                }
                else if (PlayerHand.Cards.Count == 4)
                {
                    pbPCard4.ImageLocation = PlayerHand.Cards[3].Image;
                    pbPCard4.Visible = true;
                }
                else if (PlayerHand.Cards.Count == 5)
                {
                    pbPCard5.ImageLocation = PlayerHand.Cards[4].Image;
                    pbPCard5.Visible = true;

                    btnHit.Enabled = false;
                }

                //See if you busted.
                if (PlayerHand.Total >= 21)
                {
                    label1.Text = "You Busted";
                    LogResult("Dealer");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            try
            {
                //Display the second dealer card when the player stands.
                pbDCard2.ImageLocation = DealerHand.Cards[1].Image;

                while ((DealerHand.Total <= 16) && (DealerHand.Cards.Count != 5))
                {
                    //Deal the dealer a new card.
                    DealDealerNextCard();
                }

                //See who wins.
                if (DealerHand.Total > 21)
                {
                    label1.Text = "The dealer is over 21 and loses.";
                    LogResult("Player");
                }
                else
                {
                    if (PlayerHand.Total > DealerHand.Total)
                    {
                        label1.Text = "The player wins.";
                        LogResult("Player");
                    }
                    else
                    {
                        label1.Text = "The dealer wins.";
                        LogResult("Dealer");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            try
            {
                //Deal the player 2 cards.
                PlayerHand.Cards.Add(myDeck.GetCard());
                PlayerHand.Cards.Add(myDeck.GetCard());
                PlayerHand.CalculateTotal();

                //Display both player cards and total.
                pbPCard1.ImageLocation = PlayerHand.Cards[0].Image;
                pbPCard1.Visible = true;
                pbPCard2.ImageLocation = PlayerHand.Cards[1].Image;
                pbPCard2.Visible = true;
                tbPTotal.Text = PlayerHand.Total.ToString();

                //Deal the dealer 2 cards.
                DealerHand.Cards.Add(myDeck.GetCard());
                DealerHand.Cards.Add(myDeck.GetCard());
                DealerHand.CalculateTotal();

                //Display both dealer cards and total.
                pbDCard1.ImageLocation = DealerHand.Cards[0].Image;
                pbDCard1.Visible = true;
                pbDCard2.ImageLocation = @"CardImages\back.png";
                pbDCard2.Visible = true;
                tbDTotal.Text = DealerHand.Total.ToString();

                //Disable deal button until the next game.
                btnDeal.Enabled = false;
                btnHit.Enabled = true;
                btnStand.Enabled = true;

                //Check for blackjack on the deal.
                if (DealerHand.Total == 21)
                {
                    pbDCard2.ImageLocation = DealerHand.Cards[1].Image;
                    label1.Text = "Dealer has Blackjack. The dealer wins.";
                    LogResult("Dealer");
                }
                else if (PlayerHand.Total == 21)
                {
                    label1.Text = "Player has Blackjack. The player wins.";
                    LogResult("Player");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                NewGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Event Handlers

        #region Utility methods

        private void NewGame()
        {
            pbDCard1.Visible = false;
            pbDCard2.Visible = false;
            pbDCard3.Visible = false;
            pbDCard4.Visible = false;
            pbDCard5.Visible = false;
            pbPCard1.Visible = false;
            pbPCard2.Visible = false;
            pbPCard3.Visible = false;
            pbPCard4.Visible = false;
            pbPCard5.Visible = false;

            tbDTotal.Text = "";
            tbPTotal.Text = "";
            label1.Text = "";

            PlayerHand = new BlackjackHand();
            DealerHand = new BlackjackHand();

            if (myDeck.Cards.Count < 10)
            {
                MessageBox.Show("Less than 10 cards in the current deck. Creating a new deck.");

                //Initialize a new deck.
                myDeck.Initialize();
            }

            //re-enable the deal button and disable hit and stand.
            btnDeal.Enabled = true;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
    
        }

        private void DealDealerNextCard()
        {
            //Only allow 5 cards.
            if (DealerHand.Cards.Count == 5)
            {
                MessageBox.Show("You already have five cards.");
                return;
            }

            //Add another card to the hand.
            DealerHand.Cards.Add(myDeck.GetCard());

            //Update the hand's total.
            DealerHand.CalculateTotal();

            //Display the new hand total.
            tbDTotal.Text = DealerHand.Total.ToString();

            //Figure out which card was dealt and display that card.
            if (DealerHand.Cards.Count == 3)
            {
                pbDCard3.ImageLocation = DealerHand.Cards[2].Image;
                pbDCard3.Visible = true;

            }
            else if (DealerHand.Cards.Count == 4)
            {
                pbDCard4.ImageLocation = DealerHand.Cards[3].Image;
                pbDCard4.Visible = true;
            }
            else if (PlayerHand.Cards.Count == 5)
            {
                pbDCard5.ImageLocation = DealerHand.Cards[4].Image;
                pbDCard5.Visible = true;
            }

        }

        private void LogResult(string winner)
        {
            try
            {
                //Disable hit and stand until the next game is dealt.
                btnHit.Enabled = false;
                btnStand.Enabled = false;

                GameResult GR = new GameResult();
                GR.Winner = winner;
                GR.DealerScore = DealerHand.Total;
                GR.PlayerScore = PlayerHand.Total;

                Results.AddResults(GR);

                lbResults.Items.Add(string.Format("Winner is {0}. Score is D - {1}, P = {2}", GR.Winner, GR.DealerScore, GR.PlayerScore));

                tbDealerWins.Text = Results.NumberOfDealerWins.ToString();
                tbPlayerWins.Text = Results.NumberOfPlayerWins.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Utility Methods
    }
}