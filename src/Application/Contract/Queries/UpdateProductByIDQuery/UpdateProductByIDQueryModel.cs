using Application.Common.Models;
namespace Application.Contract.Queries.UpdateProductByIDQuery
{
    public class UpdateProductByIDQueryModel : QueryModelListBase<UpdateProductByIDQueryData>
    {
    }
    public class UpdateProductByIDQueryData
    {
        public int? count_updateProductById { get; set; }
    }
}
