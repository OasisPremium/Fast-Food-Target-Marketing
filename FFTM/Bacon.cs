using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bacon : Condiments
    {
        public override int GetCalories()
        {
            return CalCalc.Calories(GetGramsOfProtein(),GetGramsOfFat(),GetGramsOfSugar());
        }

        public override int GetGramsOfFat()
        {
            return 12;
        }

        public override int GetGramsOfProtein()
        {
            return 4;
        }

        public override int GetGramsOfSugar()
        {
            return 2;
        }
    }
}
