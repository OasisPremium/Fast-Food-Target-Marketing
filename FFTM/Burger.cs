using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Burger : Burdog
    {
        private Burgerbread bread;
        private Beefpatty bp;
        private List<Condiments> conds;

        private int calories;
        private int gramsofsugar;
        private int gramsoffat;
        private int gramsofprotein;

        public Burger(TextBox T, ListBox L)
        {
            bread = new Burgerbread();
            bp = new Beefpatty();
            conds = new List<Condiments>();
            Update(T,L);
        }

        public void Update(TextBox T, ListBox L)
        {
            this.gramsoffat = bread.GramsOfFat() + bp.GramsOfFat;
            this.gramsofprotein = bread.GramsOfProtein() + bp.GramsOfProteins;
            this.gramsofsugar = bread.GramsOfSugar() + bp.GramsOfSugar;
            
            foreach (Condiments condiment in conds)
            {
                Console.WriteLine(condiment);
                this.gramsofprotein = gramsofprotein + condiment.GetGramsOfProtein();
                this.gramsoffat = gramsoffat + condiment.GetGramsOfFat();
                this.gramsofsugar = gramsofsugar + condiment.GetGramsOfSugar();
            }
            this.calories = CalCalc.Calories(gramsofprotein, gramsoffat, gramsofsugar);
            T.Text = this.calories.ToString();
        }

        public override void AddCondiment(Condiments c)
        {

            if(!conds.Contains(c))
            {
                conds.Add(c);
            }
            
        }

        public override void RemoveCondiment(Condiments c)
        {
            conds.Remove(c);
        }

        

    }
}
