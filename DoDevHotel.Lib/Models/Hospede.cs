using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class Hospede : ModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }
        public List<EstadiaXHospede> ListEstadiasXHospedes { get; set; } = new List<EstadiaXHospede>();
        public List<Estadia> ListEstadia { get; set; } = new List<Estadia>();
        public Hospede(string nome, string telefone, int cpf, string email, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Email = email;
        }
        public Hospede()
        {

        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public int GetCpf()
        {
            return Cpf;
        }
        public void SetCpf(int cpf)
        {
            Cpf = cpf;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(string telefone)
        {
            ValidarTelefone(telefone);
            Telefone = telefone;
        }
        public string GetEmail()
        {
            return Telefone;
        }
        public void SetEmail(string email)
        {
            ValidarEmail(email);
            Email = email;
        }
        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length < 14)
            {
                return true;
            }
            throw new DoDevHotelException("Error: O telefone deve ter 14 ou menos caracteres.");
        }
        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            throw new DoDevHotelException("Erro: O e-mail deve conter @.");
        }

    }
}