using Application.Interfaces;
namespace TestApi.Contract.Queries.DeleteProductQuery
{
    public class DeleteProductQuery : IProcess<DeleteProductQueryModel>
    {
        public int? id { get; set; }
    }
}
