using Application.Common.Models;
namespace Application.Contract.Queries.GetAllProductQuery
{
    public class GetAllProductQueryModel : QueryModelListBase<GetAllProductQueryData>
    {
    }
    public class GetAllProductQueryData
    {
        public int? product_id { get; set; }
        public string? product_name { get; set; }
        public string? product_price { get; set; }
        public string? product_decription { get; set; }
        public string? create_date { get; set; }
        public string? last_update_date { get; set; }
    }
}
