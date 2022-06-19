using DoDevHotel.Lib.Models;

namespace DoDevHotel.Web.DTOs
{
    public class QuartoDTO
    {
        public int Numero { get; set; }
        public int Andar { get; set; }
        public TipoQuarto id_tipo_quarto { get; set; }
        public Hotel id_hotel { get; set; }
    }
}