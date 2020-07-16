using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class CalCalc
    {
        static public int Calories(int protein, int fat, int sugar)
        {
            int totalcal = (protein * 4)+(sugar * 4)+(fat * 9);
            return totalcal;
        }
    }
}
