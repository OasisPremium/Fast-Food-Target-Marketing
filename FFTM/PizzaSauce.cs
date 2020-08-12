using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PizzaSauce
    {
        const int fat = 12;
        const int protein = 0;
        const int sugar = 38;

        public int GetCalories()
        {
            
            return CalCalc.Calories(fat, protein, sugar);
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
