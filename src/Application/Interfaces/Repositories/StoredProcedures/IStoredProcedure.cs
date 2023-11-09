using Domain.Entities.web;
using Domain.Entities.api;

namespace Application.Interfaces.Repositories.StoredProcedures
{
    public interface IStoredProcedure
    {
        Task<IEnumerable<GetProductQueryResult>> GetProductQueryAsync(int? id);
        Task<IEnumerable<GetAllProductQueryResult>> GetAllProductQueryAsync();
    }
}
