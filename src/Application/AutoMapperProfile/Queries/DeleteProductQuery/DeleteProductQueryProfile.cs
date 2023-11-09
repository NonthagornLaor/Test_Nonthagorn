using AutoMapper;
using Domain.Entities.api;
using Application.Contract.Queries.DeleteProductQuery;
namespace Application.AutoMapperProfile.Queries.DeleteProductQuery
{
    public class DeleteProductQueryProfile :Profile
    {
        public DeleteProductQueryProfile()
        {
            CreateMap<DeleteProductQueryResult, DeleteProductQueryData>();
        }
    }
}
