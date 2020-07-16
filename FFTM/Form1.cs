using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Burger burger;
        Hotdog hotdog;
        Pizza pizza;
        Chicken chicken;
        int choiceIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Burger_Click(object sender, EventArgs e)
        {
            SpecBox.Items.Clear();
            SpecBox.Items.Add("Ketchup");
            SpecBox.Items.Add("Mustard");
            SpecBox.Items.Add("Relish");
            SpecBox.Items.Add("Mayo");
            SpecBox.Items.Add("Cheese");
            SpecBox.Items.Add("Bacon");
            burger = new Burger(totalcalbox, SpecBox);
            choiceIndex = 0;

        }

        private void Hotdog_Click(object sender, EventArgs e)
        {
            SpecBox.Items.Clear();
            SpecBox.Items.Add("Ketchup");
            SpecBox.Items.Add("Mustard");
            SpecBox.Items.Add("Relish");
            SpecBox.Items.Add("Mayo");
            SpecBox.Items.Add("Cheese");
            SpecBox.Items.Add("Bacon");
            hotdog = new Hotdog();
            choiceIndex = 1;
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            SpecBox.Items.Clear();
            SpecBox.Items.Add("Peperonni & Cheese");
            SpecBox.Items.Add("All dressed");
            SpecBox.Items.Add("BBQ Chicken");
            SpecBox.Items.Add("Vegan");
            SpecBox.Items.Add("Hawaiian");
            SpecBox.Items.Add("Brooklyn Style");
            pizza = new Pizza();
            choiceIndex = 2;
        }

        private void Chicken_Click(object sender, EventArgs e)
        {
            SpecBox.Items.Clear();
            SpecBox.Items.Add("Roasted");
            SpecBox.Items.Add("Fried");
            SpecBox.Items.Add("Spicy");
            SpecBox.Items.Add("Chicken sandwich");
            SpecBox.Items.Add("Chicken wrap");
            SpecBox.Items.Add("Chicken salad");
            chicken = new Chicken();
            choiceIndex = 3;
        }

        private void SpecBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(choiceIndex == 0)
            {
                foreach(var item in SpecBox.SelectedItems)
                {
                    string ts = item.ToString();
                    if(ts == "Ketchup")
                    {
                        Ketchup k = new Ketchup();
                        burger.Conds.Add(k);
                    }
                    if(ts == "Mustard")
                    {
                        Mustard m = new Mustard();
                        burger.Conds.Add(m);
                    }

                }
                
                burger.Update(totalcalbox,SpecBox);
            }
        }
    }
}
