using DoDevHotel.Lib.Context;
using DoDevHotel.Lib.Exceptions;
using DoDevHotel.Lib.Interfaces;
using DoDevHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace DoDevHotel.Lib.Date.Repository
{
    public class HotelRepositorio : BaseRepositorio<Hotel>, IHotelRepositorio
    {
        public HotelRepositorio(DoDevHotelContext context) : base (context, context.Hoteis)
        {
            
        }
    }
}