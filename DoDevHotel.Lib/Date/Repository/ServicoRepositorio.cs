using DoDevHotel.Lib.Context;
using DoDevHotel.Lib.Exceptions;
using DoDevHotel.Lib.Interfaces;
using DoDevHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace DoDevHotel.Lib.Date.Repository
{
    public class ServicoRepositorio : BaseRepositorio<Servico>, IServicoRepositorio
    {
        public ServicoRepositorio(DoDevHotelContext context) : base(context, context.Servicos)
        {
            
        }
    }
}