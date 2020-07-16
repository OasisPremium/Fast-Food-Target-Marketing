using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Condiments
    {
        //We know condiments have some nutritional values but we can't specify exactly how much
        //And we know that each condiments NEED to have those
        //Abstract let us do that
        abstract public int GetCalories();
        public abstract int GetGramsOfSugar();
        public abstract int GetGramsOfProtein();
        public abstract int GetGramsOfFat();
    }
}
