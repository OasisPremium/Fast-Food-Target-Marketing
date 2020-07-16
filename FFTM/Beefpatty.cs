using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Beefpatty
    {
        readonly int calories;
        private const int gramsOfProteins = 28;
        const int gramsOfSugar = 0;
        const int gramsOfFat = 16;


        public Beefpatty()
        {
            calories = CalCalc.Calories(GramsOfProteins, gramsOfFat, gramsOfSugar);
        }


        
        public int GramsOfProteins
        {
            get { return GramsOfProteins; }
        }

        public int GramsOfFat
        {
            get { return GramsOfFat; }
        }

        public int GramsOfSugar
        {
            get { return GramsOfSugar; }
        }

        public int Calories
        {
            get { return calories; }
        }
    }
}
