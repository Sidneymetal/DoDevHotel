namespace DoDevHotel.Lib.Models
{
    public class ModelBase
    {
        public int Id { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public ModelBase(int id, DateTime dataAtualizacao, DateTime dataCadastro)
        {
            Id = id;
            DataAtualizacao = dataAtualizacao;
            DataCadastro = dataCadastro;
        }
        public ModelBase()
        {

        }
    }
}