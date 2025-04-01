using Microsoft.AspNetCore.Mvc;
using MQSCarDoc.Models;
using System;
using System.Windows.Forms;

namespace MQSCarDocFrontend.Controllers
{
    public class ClienteController : ControllerBase
    {
        private readonly MQSCarDocContext _context;
        private DataGridView _dgvListaCliente;

        public ClienteController(MQSCarDocContext context, DataGridView dgvListaCliente)
        {
            _context = context;
            _dgvListaCliente = dgvListaCliente;

        }

        public void CarregarClientes()
        {
            try
            {
                var clientes = _context.Clientes.Find();

                _dgvListaCliente.AutoGenerateColumns = true;
                _dgvListaCliente.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
