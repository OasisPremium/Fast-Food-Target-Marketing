using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Ketchup : Condiments
    {
        public override int GetCalories()
        {
            return 20;
        }

        public override int GetGramsOfFat()
        {
            return 0;
        }

        public override int GetGramsOfProtein()
        {
            return 0;
        }

        public override int GetGramsOfSugar()
        {
            return 4;
        }
    }
}
