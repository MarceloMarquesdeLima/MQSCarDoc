namespace MQSGestaoBackend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string UserName { get; set; }

        public Usuario()
        {
            Codigo = "Use00" + Id;
        }
    }
}
