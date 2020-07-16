using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Burger
    {
        private Burgerbread bread = new Burgerbread();
        private Beefpatty bp = new Beefpatty();
        private List<Condiments> conds = new List<Condiments>();

        private int calories;
        private int gramsofsugar;
        private int gramsoffat;
        private int gramsofprotein;

        public Burger()
        {

        }

        public void nutfacts()
        {
            foreach(Condiments c in conds)
            {

            }
            this.gramsoffat = bread.GramsOfFat() + bp.GramsOfFat;
            this.gramsofprotein = bread.GramsOfProtein() + bp.GramsOfProteins;
            this.gramsofsugar = bread.GramsOfSugar() + bp.GramsOfSugar;
            this.calories = bread.Calories() + bp.Calories;
        }

    }
}
