namespace DoDevHotel.Lib.Models
{

    public class EstadiaXHospede : ModelBase
    {
        public int IdEstadia { get; set; }
        public int IdHospede { get; set; }
        public Estadia? Estadia { get; set; }
        public Hospede? Hospede { get; set; }

        public EstadiaXHospede(int idEstadia, int idHospede, Estadia estadia, Hospede hospede, int id, DateTime dataAtualizacao, DateTime dataCadastro) : base(id, dataAtualizacao, dataCadastro)
        {
            IdEstadia = idEstadia;
            IdHospede = idHospede;
            Estadia = estadia;
            Hospede = hospede;
            
        }
        public EstadiaXHospede()
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
        public int GetIdHospede()
        {
            return IdHospede;
        }
        public void SetIdHospede(int idHospede)
        {
            IdHospede = idHospede;
        }
        public Estadia GetEstadia()
        {
            return Estadia;
        }
        public void SetEstadia(Estadia estadia)
        {
            Estadia = estadia;
        }
        public Hospede GetHospede()
        {
            return Hospede;
        }
        public void SetHospede(Hospede hospede)
        {
            Hospede = hospede;
        }


    }
   
}
