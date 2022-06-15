namespace DoDevHotel.Lib.Models
{
    public class Estadia : ModelBase
    {
        public DateTime DataEntrada{ get; set;}    
        public Hospede DataSaida { get; set; }
        public Hotel id_hotel { get; set; } 
        
        public Estadia (int id, DateTime dataAtualizacao, DateTime dataCadastro) : base (id, dataAtualizacao, dataCadastro)
        {
            
        }
    }   
}