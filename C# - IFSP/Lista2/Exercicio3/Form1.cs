﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void rdbEsconder_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
