using DoDevHotel.Lib.Models;

namespace DoDevHotel.Web.DTOs
{
    public class EstadiaXHospedeDTO : ModelBase
    {
       public Estadia id_estadia {get;set;} 
       public Hospede id_hospede {get;set;} 
    }
}