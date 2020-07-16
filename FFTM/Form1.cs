using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Burger burger;
        Hotdog hotdog;
        Pizza pizza;
        Chicken chicken;

        Mustard m = new Mustard();
        Ketchup k = new Ketchup();
        
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
            
            switch (choiceIndex)
            {
                
                case 0:
                    if (SpecBox.SelectedItems.Contains("Ketchup"))
                    {
                        burger.AddCondiment(k);
                        Console.WriteLine("kkkkkkkkk");
                    }
                    else
                    {
                        burger.RemoveCondiment(k);
                        Console.WriteLine("NoKetchup");
                    }
                    if (SpecBox.SelectedItems.Contains("Mustard"))
                    {
                        burger.AddCondiment(m);
                        Console.WriteLine("kkkkkkkkk");
                    }
                    else
                    {
                        burger.RemoveCondiment(m);
                        Console.WriteLine("NoKetchup");
                    }



                    /*if (SpecBox.SelectedIndex == 0)
                    {
                        burger.AddCondiment(k);
                        
                    }
                    if (SpecBox.SelectedIndex != 0)
                    {
                        burger.RemoveCondiment(k);
                    }


                    if (SpecBox.SelectedIndex == 1)
                    {
                        burger.AddCondiment(m);
                    }
                    if (SpecBox.SelectedIndex != 1)
                    {
                        burger.RemoveCondiment(m);
                    }*/

                    burger.Update(totalcalbox, SpecBox);
                    break;

                case 1:
                    if (SpecBox.SelectedIndex == 0)
                    {
                        hotdog.AddCondiment(k);
                    }
                    if (SpecBox.SelectedIndex != 0)
                    {
                        burger.RemoveCondiment(k);
                    }


                    if (SpecBox.SelectedIndex == 1)
                    {
                        burger.AddCondiment(m);
                    }
                    if (SpecBox.SelectedIndex != 1)
                    {
                        burger.RemoveCondiment(m);
                    }

                    burger.Update(totalcalbox, SpecBox);
                    break;
            }
        }
    }
}
