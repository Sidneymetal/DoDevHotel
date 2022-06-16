using System;
using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class Estadia : ModelBase
    {
        public DateTime DataEntrada{ get; set;}    
        public DateTime DataSaida{ get; set;}    
        public Hospede id_hospede { get; set; }
        public Hotel id_hotel { get; set; } 
        
        public Estadia (DateTime dataEntrada, DateTime dataSaida, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base (id, dataAtualizacao, dataCadastro)
        {
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }
        public Estadia()
        {

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