namespace DoDevHotel.Web.DTOs
{
    public class TipoQuartoDTO
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int OcupacaoMaxima { get; set; }
        public int CamaCasal { get; set; }
        public int CamaSolteiro { get; set; }
        public double Valor { get; set; }
    }
}