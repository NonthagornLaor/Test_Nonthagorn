using Application.Interfaces;
namespace TestApi.Contract.Queries.GetProductQuery
{
    public class GetProductQuery : IProcess<GetProductQueryModel>
    {
        public int? id { get; set; }
    }
}
