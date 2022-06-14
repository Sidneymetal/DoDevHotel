namespace DoDevHotel.Lib.Models
{
    public class Hospede : ModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public Hospede(string nome, string telefone, string cpf, string email) 
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Email = email;
        }
        public Hospede()
        {
            
        }
    }
}