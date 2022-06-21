using DoDevHotel.Lib.Context;
using DoDevHotel.Lib.Exceptions;
using DoDevHotel.Lib.Interfaces;
using DoDevHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;
namespace DoDevHotel.Lib.Date.Repository
{
    public class BaseRepositorio <T> : IBaseRepositorio <T> where T : ModelBase
    {
        protected readonly DoDevHotelContext _context;
        protected readonly DbSet<T> _dbset;
        public BaseRepositorio(DoDevHotelContext dbContext, DbSet<T> dbset)
        {
            _context = dbContext;
            _dbset = dbset;
        }
    }
}