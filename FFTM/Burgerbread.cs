using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Burgerbread : Bread
    {
        public override int Calories()
        {
            return 0;
        }

        public override int GramsOfProtein()
        {
            return 4;
        }

        public override int GramsOfSugar()
        {
            return 28;
        }

        public override int GramsOfFat()
        {
            return 2;
        }

        public Burgerbread()
        {
            int totalcal = CalCalc.Calories(GramsOfProtein(),GramsOfFat(),GramsOfSugar());
        }
    }
}
