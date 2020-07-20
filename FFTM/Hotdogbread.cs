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
        const int fat = 1;
        const int sugar = 14;
        const int protein = 8;


        public Hotdogbread()
        {
            calories = CalCalc.Calories(GramsOfProtein(), GramsOfFat(), GramsOfSugar());
        }

        public override int GramsOfFat()
        {
            return fat;
        }

        public override int GramsOfProtein()
        {
            return protein;
        }

        public override int GramsOfSugar()
        {
            return sugar;
        }
    }
}
