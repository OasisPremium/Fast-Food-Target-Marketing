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
        ChickenMeal ch;
        Mustard m = new Mustard();
        Ketchup k = new Ketchup();
        Relish r = new Relish();
        Mayo ma = new Mayo();
        Bacon b = new Bacon();
        Cheese c = new Cheese();
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
            hotdog = new Hotdog(totalcalbox, SpecBox);
            choiceIndex = 1;
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            SpecBox.Items.Clear();
            SpecBox.Items.Add("Peperonni");
            SpecBox.Items.Add("Cheese");
            SpecBox.Items.Add("BBQ Chicken");
            SpecBox.Items.Add("Veggies");
            SpecBox.Items.Add("Ham & Pineapple");
            SpecBox.Items.Add("Brooklyn Style");
            pizza = new Pizza(totalcalbox, SpecBox);
            choiceIndex = 2;
        }

        private void Chicken_Click(object sender, EventArgs e)
        {
            SpecBox.Items.Clear();
            SpecBox.Items.Add("Breast");
            SpecBox.Items.Add("Thigh");
            SpecBox.Items.Add("Fried");
            ch = new ChickenMeal(totalcalbox, SpecBox);
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
                    }else
                    {
                        burger.RemoveCondiment(k);
                    }

                    if (SpecBox.SelectedItems.Contains("Mustard"))
                    {
                        burger.AddCondiment(m);
                    }else
                    {
                        burger.RemoveCondiment(m);
                    }

                    if (SpecBox.SelectedItems.Contains("Relish"))
                    {
                        burger.AddCondiment(r);
                    }else
                    {
                        burger.RemoveCondiment(r);
                    }

                    if (SpecBox.SelectedItems.Contains("Mayo"))
                    {
                        burger.AddCondiment(ma);
                    }else
                    {
                        burger.RemoveCondiment(ma);
                    }

                    if (SpecBox.SelectedItems.Contains("Bacon"))
                    {
                        burger.AddCondiment(b);
                    }else
                    {
                        burger.RemoveCondiment(b);
                    }

                    if (SpecBox.SelectedItems.Contains("Cheese"))
                    {
                        burger.AddCondiment(c);
                    }else
                    {
                        burger.RemoveCondiment(c);
                    }

                    burger.Update(totalcalbox, SpecBox);
                    break;

                case 1:
                    if (SpecBox.SelectedItems.Contains("Ketchup"))
                    {
                        hotdog.AddCondiment(k);
                    }
                    else
                    {
                        hotdog.RemoveCondiment(k);
                    }

                    if (SpecBox.SelectedItems.Contains("Mustard"))
                    {
                        hotdog.AddCondiment(m);
                    }
                    else
                    {
                        hotdog.RemoveCondiment(m);
                    }

                    if (SpecBox.SelectedItems.Contains("Relish"))
                    {
                        hotdog.AddCondiment(r);
                    }
                    else
                    {
                        hotdog.RemoveCondiment(r);
                    }

                    if (SpecBox.SelectedItems.Contains("Mayo"))
                    {
                        hotdog.AddCondiment(ma);
                    }
                    else
                    {
                        hotdog.RemoveCondiment(ma);
                    }

                    if (SpecBox.SelectedItems.Contains("Bacon"))
                    {
                        hotdog.AddCondiment(b);
                    }
                    else
                    {
                        hotdog.RemoveCondiment(b);
                    }

                    if (SpecBox.SelectedItems.Contains("Cheese"))
                    {
                        hotdog.AddCondiment(c);
                    }
                    else
                    {
                        hotdog.RemoveCondiment(c);
                    }

                    hotdog.Update(totalcalbox, SpecBox);
                    break;
                case 2:
                    if (SpecBox.SelectedItems.Contains("Peperonni"))
                    {
                        pizza.AddCondiment(k);
                    }
                    else
                    {
                        pizza.RemoveCondiment(k);
                    }

                    if (SpecBox.SelectedItems.Contains("Cheese"))
                    {
                        pizza.AddCondiment(m);
                    }
                    else
                    {
                        pizza.RemoveCondiment(m);
                    }

                    if (SpecBox.SelectedItems.Contains("BBQ Chicken"))
                    {
                        pizza.AddCondiment(r);
                    }
                    else
                    {
                        pizza.RemoveCondiment(r);
                    }

                    if (SpecBox.SelectedItems.Contains("Veggies"))
                    {
                        pizza.AddCondiment(ma);
                    }
                    else
                    {
                        pizza.RemoveCondiment(ma);
                    }

                    if (SpecBox.SelectedItems.Contains("Ham & Pineapple"))
                    {
                        pizza.AddCondiment(b);
                    }
                    else
                    {
                        pizza.RemoveCondiment(b);
                    }

                    if (SpecBox.SelectedItems.Contains("Brooklyn Style"))
                    {
                        pizza.AddCondiment(c);
                    }
                    else
                    {
                        pizza.RemoveCondiment(c);
                    }

                    pizza.Update(totalcalbox, SpecBox);
                    break;

                case 3:
                    bool breast = false;
                    bool fried = false;
                    bool thigh = false;
                    if (SpecBox.SelectedItems.Contains("Fried"))
                    {
                        fried = true;
                    }
                    else
                    {
                        fried = false;
                    }
                    if (SpecBox.SelectedItems.Contains("Breast"))
                    {
                        breast = true;
                    }
                    else
                    {
                        breast = false;
                    }

                    if (SpecBox.SelectedItems.Contains("Thigh"))
                    {
                        thigh = true;
                    }
                    else
                    {
                        thigh = false;
                    }

                   
                    ch.Update(totalcalbox,thigh,breast,fried);
                    break;
            }
        }
    }
}
