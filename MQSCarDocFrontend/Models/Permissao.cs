namespace MQSMQSCarDoc.Models
{
    public class Permissao
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public Usuario NomeUsuario { get; set; }
        public bool Leitura { get; set; }
        public bool Escrita { get; set; }
        public bool Exclusao { get; set; }

        public Permissao()
        {
            Codigo = "Per00" + Id;
        }
    }
}
