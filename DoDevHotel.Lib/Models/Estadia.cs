namespace DoDevHotel.Lib.Models
{
    public class Estadia : ModelBase
    {
        public Hospede id_hospede { get; set; }
        public Hotel id_hotel { get; set; }               
    }   
}