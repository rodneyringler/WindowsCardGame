using System;
using System.Windows.Forms;
using CommonClasses;
using System.IO;

namespace PokerGame
{
    public partial class Form1 : Form
    {

        #region Fields

        CommonClasses.PokerCardGame Game = new CommonClasses.PokerCardGame();

        #endregion Fields

        #region Constructors

        public Form1()
        {
            try
            {
                InitializeComponent();

                Game.WeHaveAWinner += new PokerCardGame.WeHaveAWinnnerDelegate(ProcessWeHaveAWinner);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion Constructors

        #region Event Handlers

        private void DealProcessor(object sender, EventArgs e)
        {
            try
            {
                //Deal the cards.
                Game.Deal();

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

                label1.Text = "";

                Game.PlayerHand = new PokerHand();
                Game.DealerHand = new PokerHand();

                if (Game.myDeck.Cards.Count < 10)
                {
                    MessageBox.Show("Less than 10 cards in the current deck. Creating a new deck.");

                    //Initialize a new deck.
                    Game.myDeck.Initialize();
                }

                //re-enable the deal button..
                btnDeal.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ProcessWeHaveAWinner(string w)
        {
            //Display player cards.
            pbPCard1.ImageLocation = Game.PlayerHand.Cards[0].Image;
            pbPCard1.Visible = true;
            pbPCard2.ImageLocation = Game.PlayerHand.Cards[1].Image;
            pbPCard2.Visible = true;
            pbPCard3.ImageLocation = Game.PlayerHand.Cards[2].Image;
            pbPCard3.Visible = true;
            pbPCard4.ImageLocation = Game.PlayerHand.Cards[3].Image;
            pbPCard4.Visible = true;
            pbPCard5.ImageLocation = Game.PlayerHand.Cards[4].Image;
            pbPCard5.Visible = true;

            //Display dealercards.
            pbDCard1.ImageLocation = Game.DealerHand.Cards[0].Image;
            pbDCard1.Visible = true;
            pbDCard2.ImageLocation = Game.DealerHand.Cards[1].Image;
            pbDCard2.Visible = true;
            pbDCard3.ImageLocation = Game.DealerHand.Cards[2].Image;
            pbDCard3.Visible = true;
            pbDCard4.ImageLocation = Game.DealerHand.Cards[3].Image;
            pbDCard4.Visible = true;
            pbDCard5.ImageLocation = Game.DealerHand.Cards[4].Image;
            pbDCard5.Visible = true;

            //Disable deal button until the next game.
            btnDeal.Enabled = false;

            //Display winner.
            label1.Text = string.Format("The winner is {0}. Dealer has a {1}, Player had a {2}",
                                w, Game.DealerHand.Rank, Game.PlayerHand.Rank);

        }

        #endregion Event Handlers
    }
}