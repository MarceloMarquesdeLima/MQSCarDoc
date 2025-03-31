using System;
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
    public partial class FrmCadCliente : Form
    {
        //private ClienteController clienteController;
        public FrmCadCliente()
        {
            InitializeComponent();
            //clienteController = new ClienteController();
        }

        /*private void buttonAdicionar_Click(object sender, EventArgs e)
         {
            var cliente = new Cliente(1, "Marcelo", "marcelo@email.com");
            clienteController.AdicionarCliente(cliente);
            MessageBox.Show($"Cliente {cliente.Nome} adicionado com sucesso!");
        }

        private void buttonMostrarClientes_Click(object sender, EventArgs e)
        {
            var clientes = clienteController.ObterClientes();
            foreach (var cliente in clientes)
            {
                MessageBox.Show($"ID: {cliente.Id}, Nome: {cliente.Nome}, Email: {cliente.Email}");
            }
        }*/
       
        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void cbkPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            ValidateCbkCli();
        }

        private void cbkPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            ValidateCbkCli();
        }
        private void ValidateCbkCli()
        {
            if (cbkPessoaFisica.Checked)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            txtNome.Text = "";
            txtBairro.Text = "";
            txtTelefone.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }
    }
}
