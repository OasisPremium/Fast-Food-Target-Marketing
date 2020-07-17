using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hotdogbread : Bread
    {
        int calories;

        public Hotdogbread()
        {
            calories = CalCalc.Calories(GramsOfProtein(), GramsOfFat(), GramsOfSugar());
        }

        public override int GramsOfFat()
        {
            return 123123;
        }

        public override int GramsOfProtein()
        {
            return 0;
        }

        public override int GramsOfSugar()
        {
            return 212;
        }
    }
}
