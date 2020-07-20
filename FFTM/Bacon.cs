using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bacon : Condiments
    {
        const int fat = 12;
        const int sugar = 2;
        const int protein = 4;

        public override int GetCalories()
        {
            return CalCalc.Calories(GetGramsOfProtein(),GetGramsOfFat(),GetGramsOfSugar());
        }

        public override int GetGramsOfFat()
        {
            return fat;
        }

        public override int GetGramsOfProtein()
        {
            return protein;
        }

        public override int GetGramsOfSugar()
        {
            return sugar;
        }
    }
}
