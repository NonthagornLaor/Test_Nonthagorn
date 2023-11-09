using WebApp.Common.Models;
namespace TestApi.Contract.Queries.AddProductQuery
{
    public class AddProductQueryModel : QueryModelListBase<AddProductQueryData>
    {
    }
    public class AddProductQueryData
    {
        public int? count_addProduct { get; set; }
    }
}
