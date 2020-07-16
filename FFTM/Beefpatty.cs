using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Beefpatty
    {
        readonly int Calories;
        const int GramsOfProteins = 28;
        const int GramsOfSugar = 0;
        const int GramsOfFat = 16;

        public Beefpatty()
        {
            Calories = CalCalc.Calories(GramsOfProteins, GramsOfFat, GramsOfSugar);
        }
    }
}
