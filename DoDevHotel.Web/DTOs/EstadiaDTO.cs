using DoDevHotel.Lib.Models;

namespace DoDevHotel.Web.DTOs
{
    public class EstadiaDTO
    {
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Hospede id_hospede { get; set; }
        public Hotel id_hotel { get; set; }
    }
}