using AutoMapper;
using WebApp.Domain;
using WebApp.Service.ViewModels;

namespace WebApp.Service
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteVM, Cliente>();
        }
    }
}
