using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// Type of action will tell the action handler what type of value will be handled from the callback function.
    /// </summary>
    public enum TypeOfAction
    {
        //A teleport action will move the player to the desired index (maybe will just teleport it (ex: don't go past GO)).
        Teleport, 

        //A change balance action will be refering to a value that will change the balance of the player (ex: -100$ for the player).
        NegativeBalance,
        PositiveBalance,

        //This action will place the player in prison and make them unable to move.
        SendToPrison,

        //This action will give the player a card.
        PickUpCard
    }
}
