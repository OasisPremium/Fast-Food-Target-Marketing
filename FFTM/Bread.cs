using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Bread
    {
        private int calories;
        public abstract int GramsOfSugar();
        public abstract int GramsOfProtein();
        public abstract int GramsOfFat();
    }
}
