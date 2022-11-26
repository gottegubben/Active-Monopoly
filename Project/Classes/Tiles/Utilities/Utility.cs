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
        #region Constructors:
        //The default constructor for the utility class.
        public Utility()
        {
            rentMultiplier = 1;
        }

        //This constructor will add the ability to change the rent multiplier.
        public Utility(int rentMultiplier)
        {
            this.rentMultiplier = rentMultiplier;
        }
        #endregion

        #region Properties:
        //This multiplier will be added to the rent, the default value should be one.
        private int rentMultiplier { get; }
        #endregion

        #region Methods:
        //This function is only there to satisfy the implementation of this function and will only redirect the programmer to the desired function instead, being the overloaded function.
        public override int GetRent() { throw new Exception(@"Use the overloaded ""GetRent - method"" intead."); }

        //This function returns the rent by calculating it from the usage of a dice value. These rules are taken from the Monopoly wiki.
        public int GetRent(int propertyCount, int diceValue)
        {
            if(propertyCount >= 1)
            {
                return (((((propertyCount - 1) * 6) + 4) * diceValue) * rentMultiplier);
            }
            else
            {
                throw new Exception($"The property count should be at least 1, this value doesn't work: [{propertyCount}]!");
            }
        }
        #endregion
    }
}
