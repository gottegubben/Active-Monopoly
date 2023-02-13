using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// This class is the property class and is the class for all properties. For example: the normaly colored red streets are all part of the property class.
    /// </summary>
    public class Property : PurchasableTile
    {
        #region Constructors:
        //The default property constructor.
        public Property(int constructionCost, params int[] rent)
        {
            ConstructionCost = constructionCost;
            this.rent = rent;
        }
        #endregion

        #region Properties:
        //How many houses that are currently on this property.
        public int HouseCount { get; set; }

        //The cost of constructing a building. Either being a house or a hotel.
        public int ConstructionCost { get; set; }

        //The rent property contains all the different rents. The index corresponds to the amount of houses. For example: rent[0] is the base rent.
        private int[] rent { get; }
        #endregion

        #region Methods:
        //Overrides the base method "ChangeOwner" to accomodate for the loss of all the houses on the property.
        public override void ChangeOwner(Player newOwner)
        {
            base.ChangeOwner(newOwner);

            HouseCount = 0;
        }

        //This function will have a parameter that stands for the amount of houses you have built on that property. This function will therefore return the desired rent.
        public override int GetRent()
        {
            if(HouseCount < rent.Length && HouseCount >= 0)
            {
                return rent[HouseCount];
            }
            else
            {
                throw new Exception($"This property can't have a house count of [{HouseCount}]!");
            }
        }
        #endregion
    }
}
