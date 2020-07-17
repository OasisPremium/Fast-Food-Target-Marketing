using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Burgerbread : Bread
    {
        int calories;

        public Burgerbread()
        {
            calories = CalCalc.Calories(GramsOfProtein(),GramsOfFat(),GramsOfSugar());
        }

        public override int GramsOfFat()
        {
            return 123;
        }

        public override int GramsOfProtein()
        {
            return 123;
        }

        public override int GramsOfSugar()
        {
            return 123123;
        }
    }
}


