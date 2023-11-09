using AutoMapper;
using Domain.Entities.api;
using Application.Contract.Queries.UpdateProductByIDQuery;

namespace Application.AutoMapperProfile.Queries.UpdateProductByIDQuery
{
    public class UpdateProductByIDQueryProfile : Profile
    {
        public UpdateProductByIDQueryProfile()
        {
            CreateMap<UpdateProductByIDQueryResult, UpdateProductByIDQueryData>();
        }
    }
}
