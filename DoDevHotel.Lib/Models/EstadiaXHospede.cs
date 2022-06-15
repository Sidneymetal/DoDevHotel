namespace DoDevHotel.Lib.Models
{
    public class EstadiaXHospede : ModelBase
    {
        public Estadia id_estadia { get; set;}
        public Hospede id_hospede { get; set;} 

        public EstadiaXHospede (int id, DateTime dataAtualizacao, DateTime dataCadastro) : base (id, dataAtualizacao, dataCadastro)
        {            

        }   
    }
    
}