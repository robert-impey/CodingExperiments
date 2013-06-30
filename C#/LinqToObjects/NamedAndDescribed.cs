using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObjects
{
    class NamedAndDescribed
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("Name: '{0}' Description: '{1}'", Name, Description);
        }
    }
}
