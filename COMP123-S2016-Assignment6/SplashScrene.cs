﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_Assignment6
{
    public partial class SplashScrene : Form
    {
        public BmiCalculator FirstForm = Program.FirstForm;
        public SplashScrene()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            FirstForm.Show();
            this.Hide();
        }
    }
}
