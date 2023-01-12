using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The urgency enum is a enum that will be a factor for other classes depending on the urgency.
    /// </summary>
    public enum Urgency
    {
        None,

        Normal,

        Warning,

        Incorrect,
        
        Correct,

        Result
    }
}
