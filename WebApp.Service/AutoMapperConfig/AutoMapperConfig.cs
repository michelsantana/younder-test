using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Service { 
   public class AutoMapperConfig
    {
        public static IMapper _mapper;
        public static void RegisterMapping()
        {
            var configuration = new MapperConfiguration(r =>
            {
                r.AddProfile<DomainToViewModelMappingProfile>();
                r.AddProfile<ViewModelToDomainMappingProfile>();
            });
            configuration.AssertConfigurationIsValid();
            _mapper = configuration.CreateMapper();
        }
    }
}
