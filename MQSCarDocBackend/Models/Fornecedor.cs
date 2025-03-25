namespace MQSGestaoBackend.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public Fornecedor()
        {
            Codigo = "For00" + Id;
        }
    }
}
