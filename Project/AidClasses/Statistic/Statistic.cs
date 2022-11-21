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
        #region Checklist:
        //Vad behöver jag för data?

        //Spelare borde ha en callback metod hit till det här programmet där den skickar sig själv som objekt.

        //Vilka egendomar spelarna äger (I slutet).

        //Vilken spelare som vann och vem som förlorade (kom sist), samt alla spelares position där emellan.
        #endregion

        #region Methods:
        //This method will store the stats of the round that has been sent from the round class.
        public void StoreState(Round round)
        {
            
        }
        #endregion
    }
}
