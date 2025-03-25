namespace MQSMQSCarDoc.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public Cliente()
        {
            Codigo = "Cli00" + Id;
        }
    }
}
