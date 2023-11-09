using WebApp.Common.Models;
namespace TestApi.Contract.Queries.GetProductQuery
{
    public class GetProductQueryModel : QueryModelListBase<GetProductQueryData>
    {
    }
    public class GetProductQueryData
    {
        public int? product_id { get; set; }
        public string? product_name { get; set; }
        public string? product_price { get; set; }
        public string? product_decription { get; set; }
        public string? create_date { get; set; }
        public string? last_update_date { get; set; }

    }

}
