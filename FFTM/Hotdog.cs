using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Hotdog : Burdog
    {
        
        private Hotdogbread Hotdogbread;
        private Sausage sausage;
        private List<Condiments> conds;

        private int calories;
        private int gramsofsugar;
        private int gramsoffat;
        private int gramsofprotein;

        public Hotdog(TextBox T, ListBox L)
        {
            Hotdogbread = new Hotdogbread();
            sausage = new Sausage();
            conds = new List<Condiments>();
            Update(T,L);
        }


        public void Update(TextBox T, ListBox L)
        {
            this.gramsoffat = Hotdogbread.GramsOfFat() + sausage.GramsOfFat;
            this.gramsofprotein = Hotdogbread.GramsOfProtein() + sausage.GramsOfProteins;
            this.gramsofsugar = Hotdogbread.GramsOfSugar() + sausage.GramsOfSugar;

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
            if (!conds.Contains(c))
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
