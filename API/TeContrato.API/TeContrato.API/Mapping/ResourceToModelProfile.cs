using AutoMapper;
using Supermarket.API.Domain.Models;
using Supermarket.API.Resources;

namespace Supermarket.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveUserResource, User>();
            CreateMap<SaveClientResource, Client>();
            CreateMap<SaveCityResource, City>();
            CreateMap<SaveContractorResource, Contractor>();
            CreateMap<SaveEmployeesResource, Employees>();
            CreateMap<SavePostsResource, Posts>();
            CreateMap<SaveProjectResource, Project>();
            CreateMap<SaveJobResource, Job>();
            CreateMap<SaveControlEmployeesResource, ControlEmployees>();
            CreateMap<SaveProjectControlResource, ProjectControlResource>();
        }
    }
}