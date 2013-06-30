using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToObjects
{
    class A : NamedAndDescribed
    {
        public IList<B> Bs { get; set; }

        public A()
        {
            Bs = new List<B>();
        }
    }
}
