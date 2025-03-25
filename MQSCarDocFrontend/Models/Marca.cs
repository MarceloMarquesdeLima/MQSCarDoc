namespace MQSMQSCarDoc.Models
{
    public class Marca
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public Marca()
        {
            Codigo = "Mar00" + Id;
        }
    }
}
