using MQSCarDocFrontend.Models;
using System.Collections.Generic;

public class ClienteController
{
    private List<Cliente> clientes;

    public ClienteController()
    {
        clientes = new List<Cliente>();
    }

    public void AdicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public List<Cliente> ObterClientes()
    {
        return clientes;
    }

    public Cliente BuscarClientePorId(int id)
    {
        return clientes.Find(cliente => cliente.ID == id);
    }
}
