using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This class is the utility class and is the class for all utility tiles. For example: the electricity farm.
    /// </summary>
    public class Utility : PurchasableTile
    {
        #region Methods:
        //This function is only there to satisfy the implementation of this function and will only redirect the programmer to the desired function instead, being the overloaded function.
        public override float GetRent(int propertyCount) { throw new Exception(@"Use the overloaded ""GetRent - method"" intead."); }

        //This function returns the rent by calculating it from the usage of a dice value. These rules are taken from the Monopoly wiki.
        public float GetRent(int propertyCount, int diceValue)
        {
            if(propertyCount >= 1 && propertyCount <= 2)
            {
                return ((((propertyCount - 1) * 6) + 4) * diceValue);
            }
            else
            {
                throw new Exception($"The property amount should be between 1 & 2, this value doesn't work: [{propertyCount}]!");
            }
        }
        #endregion
    }
}
