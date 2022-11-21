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
        Teleport,

        ChangeBalance
    }
}
