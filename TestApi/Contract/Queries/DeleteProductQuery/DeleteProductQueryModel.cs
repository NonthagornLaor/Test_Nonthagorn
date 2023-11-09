using WebApp.Common.Models;
namespace TestApi.Contract.Queries.DeleteProductQuery
{
    public class DeleteProductQueryModel : QueryModelListBase<DeleteProductQueryData>
    {
    }
    public class DeleteProductQueryData
    {
        public int? count_deleteProduct { get; set; }
    }
}
