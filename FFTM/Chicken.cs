﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    abstract class Chicken
    {
        public virtual int calories()
        {
            return CalCalc.Calories(gramsofprotein(),gramsoffat(),gramsofsugar());
        }
        public abstract int gramsofsugar();
        public abstract int gramsoffat();
        public abstract int gramsofprotein();
    }
}
