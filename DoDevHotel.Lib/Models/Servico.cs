namespace DoDevHotel.Lib.Models
{
    public class Servico : ModelBase
    {
        public string Nome { get; set; }
        public Servico(string nome, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {
            Nome = nome;
        }
        public Servico()
        {
            
        }
    }
}