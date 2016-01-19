using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeTypeChecking
{
    class ChickenSandwich : Food
    {
        internal ChickenSandwich(string flavour) : base (flavour)
        {

        }

        internal override string DescribeFlavour()
        {
            return string.Format("A chicken sandwich's flavour is {0}.", Flavour);
        }
    }
}
