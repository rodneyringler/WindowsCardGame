using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClasses
{
    public class GameResult
    {
        public string Winner { get; set; }
        public int DealerScore { get; set; }
        public int PlayerScore { get; set; }
        public string DealerRank { get; set; }
        public string PlayerRank { get; set; }
    }
}
