﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQSCarDoc.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            FrmMenu novoFormulario = new FrmMenu();
            this.Hide();
            novoFormulario.ShowDialog();
        }
    }
}
