using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hotdogbread : Bread
    {
        public override int Calories()
        {
            return CalCalc.Calories(GramsOfProtein(),GramsOfFat(),GramsOfSugar());
        }

        public override int GramsOfProtein()
        {
            return 0;
        }

        public override int GramsOfSugar()
        {
            return 3;
        }

        public override int GramsOfFat()
        {
            return 0;
        }
    }
}
