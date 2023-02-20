using AutoMapper;
using LambdaSample.Core.Models;
using LambdaSample.Core.Models.Requests;
using LambdaSample.Core.Models.Responses;

namespace LambdaSample.Api.Automapper
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<ParentRequest, Parent>();
            CreateMap<Parent, ParentResponse>();
        }
    }
}
