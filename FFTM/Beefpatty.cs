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
            calories = CalCalc.Calories(gramsOfProteins, gramsOfFat, gramsOfSugar);
        }


        
        public int GramsOfProteins
        {
            get { return gramsOfProteins; }
        }

        public int GramsOfFat
        {
            get { return gramsOfFat; }
        }

        public int GramsOfSugar
        {
            get { return gramsOfSugar; }
        }

        public int Calories
        {
            get { return calories; }
        }
    }
}
