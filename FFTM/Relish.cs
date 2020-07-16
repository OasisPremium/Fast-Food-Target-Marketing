using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Relish : Condiments
    {
        public override int GetCalories()
        {
            return CalCalc.Calories(GetGramsOfProtein(),GetGramsOfFat(),GetGramsOfSugar());
        }

        public override int GetGramsOfFat()
        {
            return 0;
        }

        public override int GetGramsOfProtein()
        {
            return 1;
        }

        public override int GetGramsOfSugar()
        {
            return 5;
        }
    }
}
