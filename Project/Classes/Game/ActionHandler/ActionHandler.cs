using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class ActionHandler
    {
        #region Constructors:
        public ActionHandler(List<ActionSpace> actionspaces)
        {
            foreach (ActionSpace item in actionspaces)
            {
                item.callbackReference = callbackFunction;
            }
        }
        #endregion

        #region Methods:
        //The callback function will be called by the subclasses.
        private void callbackFunction() { }
        #endregion
    }
}
