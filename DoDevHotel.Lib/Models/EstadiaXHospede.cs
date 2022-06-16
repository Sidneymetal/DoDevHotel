namespace DoDevHotel.Lib.Models
{
    public class EstadiaXHospede : ModelBase
    {
        protected Estadia id_estadia { get; set;}
        protected Hospede id_hospede { get; set;} 

        public EstadiaXHospede (int id, DateTime dataAtualizacao, DateTime dataCadastro) : base (id, dataAtualizacao, dataCadastro)
        {            

        }   
        public EstadiaXHospede()
        {

        }
    }
    
}