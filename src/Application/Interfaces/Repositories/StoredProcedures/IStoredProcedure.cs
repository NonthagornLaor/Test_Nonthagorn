
using Domain.Entities.api;

namespace Application.Interfaces.Repositories.StoredProcedures
{
    public interface IStoredProcedure
    {
        Task<IEnumerable<GetProductQueryResult>> GetProductQueryAsync(int? id);
        Task<IEnumerable<GetAllProductQueryResult>> GetAllProductQueryAsync();
        Task<IEnumerable<AddProductQueryResult>> AddProductQueryAsync(string? product_name, string? product_decription, string? product_price);
        Task<IEnumerable<UpdateProductByIDQueryResult>> UpdateProductByIDQueryAsync(int? id, string? product_name, string? product_decription, string? product_price);
    }
}
