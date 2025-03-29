using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MQSCarDocFrontend.Banco
{
    public class Connection
    {
        public Connection()
        {
            string connectionString = "Server=nDESKTOP-VF9QGB6\\SQLEXPRESS;Database=mqscardoc;User Id=sa;Password='';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexão estabelecida com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar: {ex.Message}");
                }
            }
        }
    }
}
