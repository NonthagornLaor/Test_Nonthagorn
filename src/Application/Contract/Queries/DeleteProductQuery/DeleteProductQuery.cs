using Application.Interfaces;
namespace Application.Contract.Queries.DeleteProductQuery
{
    public class DeleteProductQuery : IProcess<DeleteProductQueryModel>
    {
        public int? id { get; set; }
    }
}
