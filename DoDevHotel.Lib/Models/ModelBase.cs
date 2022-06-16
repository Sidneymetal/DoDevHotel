using DoDevHotel.Lib.Exceptions;

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
        public int GetId()
        {
            return Id;            
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public DateTime GetDataAtualizacao()
        {
            return DataAtualizacao;
        }
        public void SetDataAtualizacao(DateTime dataAtualizacao)
        {
            DataAtualizacao = dataAtualizacao;
        }
        public DateTime GetDataCadastro()
        {
            return DataCadastro;
        }
        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }
        public bool ValidarCheckOut(DateTime dataCadastro)
        {
            if (DataAtualizacao > DataCadastro)
            {
                return true;
            }
            throw new DoDevHotelException("Data do Cadastro deve ser maior que a data da Atualização.");
        }

    }
}