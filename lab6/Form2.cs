﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lab6
{
    public partial class Form2 : Form
    {
        public Form2(string strTextBox)
        {
            InitializeComponent();
            lblFrm2KetQua.Text = strTextBox;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblFrm2KetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
