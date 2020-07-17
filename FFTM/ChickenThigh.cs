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
        public override int gramsoffat()
        {
            return 16;
        }

        public override int gramsofprotein()
        {
            return 8;
        }

        public override int gramsofsugar()
        {
            return 4;
        }
    }
}
