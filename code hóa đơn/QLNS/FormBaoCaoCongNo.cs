﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FormBaoCaoCongNo : Form
    {
        public FormBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void FormBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            DateTime thang1 = DateTime.Now;
            lbThang2.Text = thang1.ToString("MM");
        }
    }
}
