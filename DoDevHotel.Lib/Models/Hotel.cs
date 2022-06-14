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
        public Quarto id_quarto { get; set; }
        public Servico id_servico { get; set; }

        public Hotel(string nome, string telefone, string endereco, string cpf, string email, string cep, string descricao, DateTime checkin, DateTime checkout)
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
    }
}