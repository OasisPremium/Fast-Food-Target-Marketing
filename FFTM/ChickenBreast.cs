using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ChickenBreast : Chicken
    {
        const int fat = 8;
        const int protein = 16;
        const int sugar = 0;

        public override int gramsoffat()
        {
            return fat;
        }

        public override int gramsofprotein()
        {
            return protein;
        }

        public override int gramsofsugar()
        {
            return sugar;
        }
    }
}
