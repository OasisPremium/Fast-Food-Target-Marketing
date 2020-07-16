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
            this.gramsoffat = bread.GramsOfFat() + bp.GramsOfFat;
            this.gramsofprotein = bread.GramsOfProtein() + bp.GramsOfProteins;
            this.gramsofsugar = bread.GramsOfSugar() + bp.GramsOfSugar;

            foreach(Condiments condiment in conds)
            {
                this.gramsofprotein = gramsofprotein + condiment.GetGramsOfProtein();
                this.gramsoffat = gramsoffat + condiment.GetGramsOfFat();
                this.gramsofsugar = gramsofsugar + condiment.GetGramsOfSugar();
            }
            this.calories = CalCalc.Calories(gramsofprotein,gramsoffat,gramsofsugar);
        }

        

    }
}
