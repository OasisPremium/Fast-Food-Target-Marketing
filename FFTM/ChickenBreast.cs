using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ChickenBreast : Chicken
    {
        public override int gramsoffat()
        {
            return 8;
        }

        public override int gramsofprotein()
        {
            return 18;
        }

        public override int gramsofsugar()
        {
            return 4;
        }
    }
}
