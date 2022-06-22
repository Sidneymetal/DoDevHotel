using DoDevHotel.Lib.Exceptions;

namespace DoDevHotel.Lib.Models
{
    public class Quarto : ModelBase
    {
        public int IdHotel { get; set; }
        public int IdTipoQuarto { get; set; }        
        public int Numero { get; set; }
        public int Andar { get; set; }
        public Hotel? Hotel { get; set; }
        public TipoQuarto? TipoQuarto { get; set; }
        
        public List<TipoQuarto> ListTiposQuartos = new List<TipoQuarto>();

        public Quarto(int idHotel, int idTipoQuarto, int numero, int andar, Hotel hotel, TipoQuarto tipoQuarto, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {
            IdHotel = idHotel;
            IdTipoQuarto = idTipoQuarto;
            Numero = numero;
            Andar = andar;
            Hotel = hotel;
            TipoQuarto = tipoQuarto;
        }
        public Quarto()
        {

        }

        public int GetNumero()
        {
            return Numero;
        }
        public void SetNumero(int numero)
        {
            Numero = numero;
        }
        public int GetAndar()
        {
            return Andar;
        }
        public void SetAndar(int andar)
        {            
            Andar = andar;
        }        
    }
}