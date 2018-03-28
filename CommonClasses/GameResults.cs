using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class GameResults
    {
        #region Properties

        public List<GameResult> Results { get; set; }  = new List<GameResult>();
        public string ResultsFile { get; set; }
        public int NumberOfDealerWins { get; set; } = 0;
        public int NumberOfPlayerWins { get; set; } = 0;

        #endregion Properties

        #region Constructor

        public GameResults(string FileName)
        {
            ResultsFile = FileName;

            ImportExistingResults();
        }

        #endregion Constructor

        #region Methods

        public void AddResults(GameResult GR)
        {
            Results.Add(GR);

            if (GR.Winner == "Dealer")
            {
                NumberOfDealerWins++;
            }
            else
            {
                NumberOfPlayerWins++;
            }

            //Write results to file.
            StreamWriter SW = new StreamWriter(ResultsFile, true);
            SW.WriteLine(string.Format("The winner is {0} and the score is {1} {2}", GR.Winner, GR.DealerScore, GR.PlayerScore));
            SW.Close();
        }

        private void ImportExistingResults()
        {
            //StreamReader SR = new StreamReader(ResultsFile);

            //try
            //{

            //    while (!SR.EndOfStream)
            //    {
            //        string[] Result = SR.ReadLine().Split(' ');

            //        if (Result.Length > 9)
            //        {

            //            GameResult GR = new GameResult();
            //            GR.Winner = Result[3];
            //            GR.DealerScore = Convert.ToInt32(Result[8]);
            //            GR.PlayerScore = Convert.ToInt32(Result[9]);

            //            Results.Add(GR);

            //            if (GR.Winner == "Dealer")
            //            {
            //                NumberOfDealerWins++;
            //            }
            //            else
            //            {
            //                NumberOfPlayerWins++;
            //            }
            //        }

            //    }
            //}
            //catch(Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    SR.Close();
            //}
        }

        #endregion Methods
    }
}


