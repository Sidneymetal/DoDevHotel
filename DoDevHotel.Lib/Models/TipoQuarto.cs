namespace DoDevHotel.Lib.Models
{
    public class TipoQuarto : ModelBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int OcupacaoMaxima { get; set; }
        public int CamaCasal { get; set; }
        public int CamaSolteiro { get; set; }
        public double Valor { get; set; }
        public TipoQuarto(string nome, string descricao, int ocupacaoMaxima, int camaCasal, int camaSolteiro, double valor)
        {
            Nome = nome;
            Descricao = descricao;
            OcupacaoMaxima = ocupacaoMaxima;
            CamaCasal = camaCasal;
            CamaSolteiro = camaSolteiro;
            Valor = valor;            
        }
        public TipoQuarto()
        {

        }
    }
}