namespace MQSGestaoBackend.Models
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public Modelo()
        {
            Codigo = "Mod00" + Id;
        }
    }
}
