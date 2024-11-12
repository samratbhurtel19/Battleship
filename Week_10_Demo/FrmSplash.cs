﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_10_Demo
{
    public partial class FrmSplash : Form
    {
        private frmStudents frmS;
        public FrmSplash(frmStudents frm)
        {
            InitializeComponent();
            frmS = frm;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmS.Show(); 
            this.Close();
        }
    }
}