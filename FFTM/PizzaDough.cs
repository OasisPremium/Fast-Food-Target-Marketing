using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PizzaDough
    {
        const int fat = 3;
        const int protein = 0;
        const int sugar = 12;


        public int GetCalories()
        {
            return CalCalc.Calories(protein,fat,sugar);
        }

        public int GetGramsOfFat()
        {
            return fat;
        }

        public int GetGramsOfProtein()
        {
            return protein;
        }

        public int GetGramsOfSugar()
        {
            return sugar;
        }
    }
}
