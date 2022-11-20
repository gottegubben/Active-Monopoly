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
        #region Properties:
        //The rent property contains all the different rents. The index corresponds to the amount of houses. For example: rent[0] is the base rent.
        private float[] rent { get; }
        #endregion

        #region Methods:
        //This function will have a parameter that stands for the amount of properties of the same sort you own. This function will therefore return the desired rent.
        public override float GetRent(int propertyCount)
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
