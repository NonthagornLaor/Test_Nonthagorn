using Application.Interfaces;
namespace TestApi.Contract.Queries.UpdateProductByID
{
    public class UpdateProductByIDQuery : IProcess<UpdateProductByIDQueryModel>
    {
        public int? id { get; set; }
        public string? product_name { get; set; }
        public string? product_decription { get; set; }
        public string? product_price { get; set; }
    }
}
