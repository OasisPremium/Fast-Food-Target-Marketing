using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Mayo : Condiments
    {
        public override int GetCalories()
        {
            return CalCalc.Calories(GetGramsOfProtein(),GetGramsOfFat(), GetGramsOfSugar());
        }

        public override int GetGramsOfFat()
        {
            return 6;
        }

        public override int GetGramsOfProtein()
        {
            return 0;
        }

        public override int GetGramsOfSugar()
        {
            return 2;
        }
    }
}
