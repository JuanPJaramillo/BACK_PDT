using PDT.CORE.Entities;

namespace PDT.CORE.Interfaces
{
    public interface IFlightRepository
    {
        Task<IEnumerable<Flight>> GetAll();
        Task Add(Flight datos);
    }
}
