using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This class is the station class and is the class for all stations. For example: the railroad station.
    /// </summary>
    public class Station : PurchasableTile
    {
        #region Constructors:
        //The default constructor of the station class.
        public Station(params int[] rent)
        {
            this.rent = rent;
        }
        #endregion

        #region Properties:
        //The rent property contains all the different rents. The index corresponds to the amount of houses. For example: rent[0] is the base rent.
        private int[] rent { get; }
        #endregion

        #region Methods:
        //This function is only there to satisfy the implementation of this function and will only redirect the programmer to the desired function instead, being the overloaded function.
        public override int GetRent() { throw new Exception(@"Use the overloaded ""GetRent - method"" intead."); }

        //This function will have a parameter that stands for the amount of properties of the same sort you own. This function will therefore return the desired rent.
        public int GetRent(int propertyCount)
        {
            if (propertyCount <= rent.Length && propertyCount < 1)
            {
                return rent[propertyCount - 1];
            }
            else
            {
                throw new Exception($"This station can't have a property count of [{propertyCount}]!");
            }
        }
        #endregion
    }
}
