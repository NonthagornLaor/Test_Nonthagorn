using Application.Interfaces;
namespace Application.Contract.Queries.GetProductQuery
{
    public class GetProductQuery : IProcess<GetProductQueryModel>
    {
        public int? id { get; set; }
    }
}
