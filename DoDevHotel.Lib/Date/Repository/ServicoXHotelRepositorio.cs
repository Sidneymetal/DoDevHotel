using DoDevHotel.Lib.Context;
using DoDevHotel.Lib.Exceptions;
using DoDevHotel.Lib.Interfaces;
using DoDevHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace DoDevHotel.Lib.Date.Repository
{
    public class ServicoXHotelRepositorio : BaseRepositorio<ServicoXHotel>, IServicoXHotelRepositorio
    {
        public ServicoXHotelRepositorio(DoDevHotelContext context) : base (context, context.ServicosXHoteis)
        {
            
        }   
    }
}