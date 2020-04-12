using AutoMapper;
using WebApp.Domain;
using WebApp.Service.ViewModels;

namespace WebApp.Service
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteVM>();
        }
    }
}
