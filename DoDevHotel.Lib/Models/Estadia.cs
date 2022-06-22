using System;
using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class Estadia : ModelBase
    {
        public int IdHospede {get;set;}
        public int IdHotel {get;set;}
        public DateTime DataEntrada{ get; set;}    
        public DateTime DataSaida{ get; set;}    
        public Hospede? Hospede { get; set; }
        public Hotel? Hotel { get; set; }
        public List<EstadiaXHospede> ListEstadiasXHospedes { get; set; } = new List<EstadiaXHospede>();
        
        public Estadia (int idHospede, int idHotel, DateTime dataEntrada, DateTime dataSaida, Hospede hospede, Hotel hotel, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base (id, dataAtualizacao, dataCadastro)
        {
            IdHospede = idHospede;
            IdHotel = idHotel;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            Hospede = hospede;
            Hotel = hotel;
        }
        public Estadia()
        {

        }
        public int GetIdHospede()
        {
            return IdHospede;
        }
        public void SetIdHospede(int idHospede)
        {
            IdHospede = idHospede;
        }
        public int GetIdHotel()
        {
            return IdHotel;
        }
        public void SetIdHotel(int idHotel)
        {
            IdHotel = idHotel;
        }
        public DateTime GetDataEntrada()
        {
            return DataEntrada;
        }
        public void SetDataEntrada(DateTime dataEntrada)
        {            
            DataEntrada = dataEntrada;
        }
        public DateTime GetDataSaida()
        {
            return DataSaida;
        }
        public void SetDataSaida(DateTime dataSaida)
        {
            ValidarDataSaida(dataSaida);           
            DataSaida = dataSaida;
        }
        public Hospede GetHospede()
        {
            return Hospede;
        }
        public void SetHospede(Hospede hospede)
        {
            Hospede = hospede;
        }
        public Hotel GetHotel()
        {
            return Hotel;
        }
        public void SetHotel(Hotel hotel)
        {
            Hotel = hotel;
        }
        public bool ValidarDataSaida(DateTime dataSaida)
        {
            if(DataSaida > DataEntrada)
            {
                return true;
            }
            throw new DoDevHotelException("Data de Saída deve ser maior que a data de Entrada.");
        }
    }   
}