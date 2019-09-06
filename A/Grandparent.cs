using B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public class Grandparent
    {
        public Parent GetParent()
        {
            return new Parent();
        }
    }
}
