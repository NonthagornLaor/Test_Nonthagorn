using AutoMapper;
using Domain.Entities.api;
using Application.Contract.Queries.GetProductQuery;
namespace Application.AutoMapperProfile.Queries.GetProductQuery
{
    public class GetProductQueryProfile : Profile
    {
        public GetProductQueryProfile()
        {
            CreateMap<GetProductQueryResult, GetProductQueryData>();
        }
    }
}
