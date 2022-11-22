using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The tax class is a action space where, when stepped on, the player has to pay the tax sum.
    /// </summary>
    public class Tax : ActionSpace
    {
        #region Constructors:
        //The default constructor. The tax value will decide how much the player have to pay when stepping on it.
        public Tax(int tax)
        {
            this.tax = tax;
        }
        #endregion

        #region Properties:
        //The tax that the player will have to pay.
        private int tax { get; }
        #endregion

        #region Methods:
        //This will make the player pay a sum.
        public override void Action()
        {
            if (PerformActionCallbackRef != null) { PerformActionCallbackRef(tax, TypeOfAction.ChangeBalance); }
        }
        #endregion
    }
}
