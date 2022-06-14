namespace DoDevHotel.Lib.Models
{
    public class Servico : ModelBase
    {
        public string Nome { get; set; }
        public Servico(string nome)
        {
            Nome = nome;
        }
        public Servico()
        {
            
        }
    }
}