using System;
using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class Estadia : ModelBase
    {
        public int IdResponsavel { get; set; }
        public int IdQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Hospede Responsavel { get; set; }
        public Quarto Quarto { get; set; }
        public List<EstadiaXHospede> ListEstadiasXHospedes { get; set; } = new List<EstadiaXHospede>();
        public Estadia(int idResponsavel, int idQuarto, DateTime dataEntrada, DateTime dataSaida, Hospede responsavel, Quarto quarto, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {
            IdResponsavel = idResponsavel;
            IdQuarto = idQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            Responsavel = responsavel;
            Quarto = quarto;
        }
        public Estadia()
        {

        }
        public int GetIdResponsavel()
        {
            return IdResponsavel;
        }
        public void SetIdResponsavel(int idResponsavel)
        {
            IdResponsavel = idResponsavel;
        }
        public int GetIdQuarto()
        {
            return IdQuarto;
        }
        public void SetIdQuarto(int idQuarto)
        {
            IdQuarto = idQuarto;
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
        public Quarto GetQuarto()
        {
            return Quarto;
        }
        public void SetQuarto(Quarto quarto)
        {
           Quarto = quarto;
        }
              
        public bool ValidarDataSaida(DateTime dataSaida)
        {
            if (DataSaida > DataEntrada)
            {
                return true;
            }
            throw new DoDevHotelException("Data de Saída deve ser maior que a data de Entrada.");
        }
    }
}