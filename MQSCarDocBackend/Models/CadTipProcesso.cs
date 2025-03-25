namespace MQSGestaoBackend.Models
{
    public class CadTipProcesso
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public CadTipProcesso()
        {
            Codigo = "TpPro00" + Id;
        }
    }
}
