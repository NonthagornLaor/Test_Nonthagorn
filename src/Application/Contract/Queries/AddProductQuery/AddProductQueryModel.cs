using Application.Common.Models;
namespace Application.Contract.Queries.AddProductQuery
{
    public class AddProductQueryModel : QueryModelListBase<AddProductQueryData>
    {
    }
    public class AddProductQueryData
    {
        public int? count_addProduct { get; set; }
    }
}
