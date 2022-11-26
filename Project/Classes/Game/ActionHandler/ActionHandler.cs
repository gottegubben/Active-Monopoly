using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The action handler will recieve the actions performed by the subclasses and handle it.
    /// </summary>
    public class ActionHandler
    {
        #region Constructors:
        //The constructor will take in a list of actionspaces to allow for referencing the callback function to them.
        public ActionHandler(List<ActionSpace> actionspaces)
        {
            //This code forces the reference to the callback method as a variable in the subclasses.
            foreach (ActionSpace item in actionspaces)
            {
                item.PerformActionCallbackRef = handleAction;
            }
        }
        #endregion

        #region Methods:
        //The callback function will be called by the subclasses. The value object will be transformed to another class depending on the type of action that is being performed.
        private void handleAction(object value, TypeOfAction typeOfAction) 
        {
            //the temp variable is the temporary used (value as the prefered class).
            if(typeOfAction == TypeOfAction.Teleport)
            {
                throw new NotImplementedException();
            }
            else if(typeOfAction == TypeOfAction.ChangeBalance)
            {
                throw new NotImplementedException();
            }
            else if(typeOfAction == TypeOfAction.SendToPrison)
            {
                //The player's "canMove" variable should be altered.

                int temp = (int)value;

                throw new NotImplementedException();
            }
            else if(typeOfAction == TypeOfAction.PickUpCard)
            {
                CardType temp = (CardType)value;

                throw new NotImplementedException();
            }
        }
        #endregion
    }
}
