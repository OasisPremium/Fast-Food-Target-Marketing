using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ChickenThigh : Chicken
    {
        const int fat = 16;
        const int protein = 8;
        const int sugar = 4;

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
            return 4;
        }
    }
}
