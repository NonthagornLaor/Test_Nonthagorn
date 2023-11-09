using WebApp.Common.Models;
namespace TestApi.Contract.Queries.UpdateProductByID
{
    public class UpdateProductByIDQueryModel : QueryModelListBase<UpdateProductByIDQueryData>
    {
    }
    public class UpdateProductByIDQueryData
    {
        public int? count_updateProductById { get; set; }
    }
}
