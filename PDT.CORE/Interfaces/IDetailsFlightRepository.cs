using PDT.CORE.Entities;

namespace PDT.CORE.Interfaces
{
    public interface IDetailsFlightRepository
    {
        Task<IEnumerable<DetailsFlight>> GetAll();
        Task Add(DetailsFlight datos);
    }
}
