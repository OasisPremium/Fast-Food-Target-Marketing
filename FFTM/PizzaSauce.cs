using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PizzaSauce
    {
        public int GetCalories()
        {
            return CalCalc.Calories(GetGramsOfProtein(), GetGramsOfFat(), GetGramsOfSugar());
        }

        public int GetGramsOfFat()
        {
            return 1;
        }

        public int GetGramsOfProtein()
        {
            return 0;
        }

        public int GetGramsOfSugar()
        {
            return 12;
        }
    }
}
