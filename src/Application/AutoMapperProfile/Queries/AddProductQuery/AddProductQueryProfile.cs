using AutoMapper;
using Domain.Entities.api;
using Application.Contract.Queries.AddProductQuery;

namespace Application.AutoMapperProfile.Queries.AddProductQuery
{
    public class AddProductQueryProfile : Profile
    {
        public AddProductQueryProfile()
        {
            CreateMap<AddProductQueryResult, AddProductQueryData>();
        }
    }
}
