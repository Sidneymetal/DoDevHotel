using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class Hotel : ModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }
        public int Cep { get; set; }
        public string Descricao { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }        

        public Hotel(string nome, string telefone, string endereco, int cpf, string email, int cep, string descricao, DateTime checkin, DateTime checkout, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
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
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
        public int GetCpf()
        {
            return Cpf;
        }
        public void SetCpf(int cpf)
        {
            Cpf = cpf;
        }
        public int GetCep()
        {
            return Cep;
        }
        public void SetCep(int cep)
        {
            Cep = cep;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
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
        public DateTime GetCheckIn()
        {
            return CheckIn;
        }
        public void SetCheckIn(DateTime checkIn)
        {            
            CheckIn = checkIn;
        }
        public DateTime GetCheckOut()
        {
            return CheckOut;
        }        
        public void SetCheckOut(DateTime checkOut)
        {
            ValidarCheckOut(checkOut);
            CheckOut = checkOut;
        }
        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length < 15)
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
        public bool ValidarCheckOut(DateTime checkout)
        {
            if (CheckIn < CheckOut)
            {
                return true;
            }
            throw new DoDevHotelException("Data do Checkout deve ser maior que a data do Checkin.");
        }
    }
}