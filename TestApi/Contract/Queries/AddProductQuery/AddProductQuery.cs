using Application.Interfaces;
namespace TestApi.Contract.Queries.AddProductQuery
{
    public class AddProductQuery : IProcess<AddProductQueryModel>
    {
        public string? product_name { get; set; }
        public string? product_decription { get; set; }
        public string? product_price { get; set; }
    }
}
