using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQSCarDocFrontend.Views
{
    public partial class FrmCadFornecedor : Form
    {
        public FrmCadFornecedor()
        {
            InitializeComponent();
        }

        private void cbkPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            ValidateCbkFor();
        }

        private void cbkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            ValidateCbkFor();            
        }

        private void ValidateCbkFor()
        {
            if(cbkPessoaFisica.Checked)
            {
                cbkPessoaFisica.Enabled = cbkPessoaFisica.Checked;
                cbkPessoaJuridica.Enabled = false;
                txtCnpj.Enabled = false;
                txtInscEstadual.Enabled = false;
                txtCpf.Enabled = true;
                txtRg.Enabled = true;
            }
            else
            {
                cbkPessoaJuridica.Enabled = cbkPessoaJuridica.Checked;
                cbkPessoaFisica.Enabled = false;
                txtCnpj.Enabled = true;
                txtInscEstadual.Enabled = true;
                txtCpf.Enabled = false;
                txtRg.Enabled = false;
            }
        }
    }
}
