using DoDevHotel.Lib.Context;
using DoDevHotel.Lib.Exceptions;
using DoDevHotel.Lib.Interfaces;
using DoDevHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace DoDevHotel.Lib.Date.Repository
{
    public class QuartoRepositorio : BaseRepositorio<Quarto>, IQuartoRepositorio
    {
        public QuartoRepositorio(DoDevHotelContext context) : base (context, context.Quartos)
        {

        }
    }
}