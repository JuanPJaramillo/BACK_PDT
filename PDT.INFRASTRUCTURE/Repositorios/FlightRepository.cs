using Microsoft.EntityFrameworkCore;
using PDT.CORE.Entities;
using PDT.CORE.Interfaces;
using PDT.INFRASTRUCTURE.DBDatos;

namespace PDT.INFRASTRUCTURE.Repositorios
{
    public class FlightRepository : IFlightRepository
    {
        private readonly TDPContext _context;

        public FlightRepository(TDPContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Flight>> GetAll()
        {
            return await _context.Flights.ToListAsync();
        }
        public async Task Add(Flight datos)
        {
            await _context.Flights.AddAsync(datos);
            await _context.SaveChangesAsync();
        }
    }
}
