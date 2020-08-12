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
        const int fat = 10;
        const int protein = 10;
        const int sugar = 4;

        public Burgerbread()
        {
            calories = CalCalc.Calories(GramsOfProtein(),GramsOfFat(),GramsOfSugar());
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


