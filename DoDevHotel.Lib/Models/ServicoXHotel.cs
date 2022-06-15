namespace DoDevHotel.Lib.Models
{
    public class ServicoXHotel : ModelBase
    {
        public Estadia id_estadia { get; set; }
        public Hotel id_hotel { get; set; }

        public ServicoXHotel(int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {

        }
    }
}