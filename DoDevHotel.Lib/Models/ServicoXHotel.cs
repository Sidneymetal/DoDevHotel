namespace DoDevHotel.Lib.Models
{
    public class ServicoXHotel : ModelBase
    {
        public int IdEstadia{ get; set; }
        public int IdHotel { get; set; }
        public Estadia? Estadia { get; set; }
        public Hotel? Hotel { get; set; }

        public ServicoXHotel(int idEstadia, int idHotel, Estadia estadia, Hotel hotel, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {   
            IdEstadia = idEstadia;
            IdHotel = idHotel;
            Estadia = estadia;
            Hotel = hotel;
        }
        public ServicoXHotel()
        {
            
        }
        public int GetIdEstadia()
        {
            return IdEstadia;
        }
        public void SetIdEstadia(int idEstadia)
        {
            IdEstadia = idEstadia;
        }
        public int GetIdHotel()
        {
            return IdHotel;
        }
        public void SetIdHotel(int idHotel)
        {
            IdHotel = idHotel;
        }
        public Estadia GetEstadia()
        {
            return Estadia;
        }
        public void SetEstadia(Estadia estadia)
        {
            Estadia = estadia;
        }
        public Hotel GetHotel()
        {
            return Hotel;
        }
        public void SetHotel(Hotel hotel)
        {
            Hotel = hotel;
        }
    }
}