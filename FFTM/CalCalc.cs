using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class CalCalc
    {
        //return calories based on grams of prot/fat/sug
        static public int Calories(int protein, int fat, int sugar)
        {
            int totalcal = (protein * 4)+(sugar * 4)+(fat * 9);
            return totalcal;
        }

        //Show total calories in textbox
        static public int TotalCalories()
        {

            return 0;
        }
    }
}
