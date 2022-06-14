namespace DoDevHotel.Lib.Models
{
    public class Quarto : ModelBase
    {
        public int Numero { get; set; }
        public int Andar{ get; set; }
        public TipoQuarto id_tipo_quarto { get; set; }

        public Quarto(int numero, int andar)
        {
            Numero = numero;
            Andar = andar;
        }
        public Quarto()
        {
            
        }
    }
}