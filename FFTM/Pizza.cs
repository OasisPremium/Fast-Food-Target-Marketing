using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Pizza
    {
        private PizzaDough dough;
        private PizzaSauce sauce;
        private List<Condiments> conds;

        private int calories;
        private int gramsofsugar;
        private int gramsoffat;
        private int gramsofprotein;

        public Pizza(TextBox T, ListBox L)
        {
            dough = new PizzaDough();
            sauce = new PizzaSauce();
            conds = new List<Condiments>();
            Update(T,L);
        }

        public void Update(TextBox T, ListBox L)
        {
            this.gramsoffat = dough.GetGramsOfFat() + sauce.GetGramsOfFat();
            this.gramsofprotein = dough.GetGramsOfProtein() + sauce.GetGramsOfProtein();
            this.gramsofsugar = dough.GetGramsOfSugar() + sauce.GetGramsOfSugar();

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

        public void AddCondiment(Condiments c)
        {
            if (!conds.Contains(c))
            {
                conds.Add(c);
            }
        }

        public void RemoveCondiment(Condiments c)
        {
            conds.Remove(c);
        }
    }
}
