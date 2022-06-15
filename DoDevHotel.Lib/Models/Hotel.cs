using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class Hotel : ModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Descricao { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }        

        public Hotel(string nome, string telefone, string endereco, string cpf, string email, string cep, string descricao, DateTime checkin, DateTime checkout, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Cpf = cpf;
            Email = email;
            Cep = cep;
            Descricao = descricao;
            CheckIn = checkin;
            CheckOut = checkout;           
        }
        public Hotel()
        {
            
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