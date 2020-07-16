using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Bread
    {
        //Just like condiments, we know some basic components of a bread
        //But we are not sure of what TYPE of bread and specs
        public abstract int Calories();
        public abstract int GramsOfSugar();
        public abstract int GramsOfProtein();
        public abstract int GramsOfFat();

    }
}
