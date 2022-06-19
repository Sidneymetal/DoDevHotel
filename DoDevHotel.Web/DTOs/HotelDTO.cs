namespace DoDevHotel.Web.DTOs
{
    public class HotelDTO
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

    }
}