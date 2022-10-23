using Microsoft.EntityFrameworkCore;
using PDT.CORE.Entities;
using PDT.CORE.Interfaces;
using PDT.INFRASTRUCTURE.DBDatos;

namespace PDT.INFRASTRUCTURE.Repositorios
{
    public class DetailsFlightRepository : IDetailsFlightRepository
    {
        private readonly TDPContext _context;

        public DetailsFlightRepository(TDPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DetailsFlight>> GetAll()
        {
            return await _context.DetailsFlights.ToListAsync();
        }
        public async Task Add(DetailsFlight datos)
        {
            await _context.DetailsFlights.AddAsync(datos);
            await _context.SaveChangesAsync();
        }
    }
}
