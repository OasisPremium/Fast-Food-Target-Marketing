using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ChickenMeal
    {
        private int gramsofsugar;
        private int gramsoffat;
        private int gramsofprotein;
        private ChickenThigh ct;
        private ChickenBreast cb;

        public ChickenMeal(TextBox T, ListBox L)
        {
            this.ct = new ChickenThigh();
            this.cb = new ChickenBreast();
            this.gramsoffat = 0;
            this.gramsofsugar = 0;
            this.gramsofprotein = 0;
            T.Text = "";
        }

        private int calories()
        {
            return CalCalc.Calories(this.gramsofprotein, this.gramsoffat, this.gramsofsugar);
        }

        public void Update(TextBox T, bool thigh, bool breast, bool fried)
        {
            this.gramsoffat = 0;
            this.gramsofsugar = 0;
            this.gramsofprotein = 0;
            if (fried)
            {
                if (thigh)
                {
                    this.gramsoffat = this.gramsoffat + ct.gramsoffat() * 2;
                    this.gramsofsugar = this.gramsofsugar + ct.gramsofsugar();
                    this.gramsofprotein = this.gramsofprotein + ct.gramsofprotein();
                }
                if (breast)
                {
                    this.gramsoffat = this.gramsoffat + cb.gramsoffat() * 2;
                    this.gramsofsugar = this.gramsofsugar + cb.gramsofsugar();
                    this.gramsofprotein = this.gramsofprotein + cb.gramsofprotein();
                }
            }
            else
            {
                if (thigh)
                {
                    this.gramsoffat = this.gramsoffat + ct.gramsoffat();
                    this.gramsofsugar = this.gramsofsugar + ct.gramsofsugar();
                    this.gramsofprotein = this.gramsofprotein + ct.gramsofprotein();
                }
                if (breast)
                {
                    this.gramsoffat = this.gramsoffat + cb.gramsoffat();
                    this.gramsofsugar = this.gramsofsugar + cb.gramsofsugar();
                    this.gramsofprotein = this.gramsofprotein + cb.gramsofprotein();
                }
            }
            T.Text = calories().ToString();
        }
    }
}
