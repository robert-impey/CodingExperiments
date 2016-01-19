using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeTypeChecking
{
    class Food
    {
        private readonly string flavour;

        internal Food(string flavour)
        {
            this.flavour = flavour;
        }

        internal string Flavour
        {
            get
            {
                return flavour;
            }
        }

        internal virtual string DescribeFlavour()
        {
            return string.Format("This food's flavour is {0}.", Flavour);
        }
    }
}
