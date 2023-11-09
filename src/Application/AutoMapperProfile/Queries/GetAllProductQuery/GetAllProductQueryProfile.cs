using AutoMapper;
using Domain.Entities.api;
using Application.Contract.Queries.GetAllProductQuery;
namespace Application.AutoMapperProfile.Queries.GetAllProductQuery
{
    public class GetAllProductQueryProfile : Profile
    {
        public GetAllProductQueryProfile()
        {
            CreateMap<GetAllProductQueryResult, GetAllProductQueryData>();
        }
    }
}
