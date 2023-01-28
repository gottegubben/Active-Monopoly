using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The statistic class will store key information from the game. This data will be of very importance for the conclusion.
    /// </summary>
    public class Statistic
    {
        #region Properties:
        //This list will contain all the rounds that have been played before in a match.
        public List<Round> RoundHistory { get; private set; }
        #endregion

        #region Methods:
        //This method will store the stats of the round that has been sent from the round class.
        public void StoreState(Round round)
        {
            RoundHistory.Add(round);

            //Do something under that could be useful. Like who is winning right now? Who is first when it comes to money etc.
            //Maybe record the moves also.
        }

        //Creates a stat collection that contains all the necessary data for the study.
        public StatCollection CreateStat()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
