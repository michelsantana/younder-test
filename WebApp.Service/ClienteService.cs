using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;
using WebApp.DB;
using WebApp.Service.Interface;
using WebApp.Service.ViewModels;
using WebApp.DB.Interface;

namespace WebApp.Service
{
    public class ClienteService : iClienteService
    {
        iClienteRepository _cliente;

        public ClienteService(iClienteRepository cliente)
        {
            _cliente = cliente;
        }

        public ClienteVM Add(ClienteVM cliente)
        {
            var domain = AutoMapperConfig._mapper.Map<Cliente>(cliente);
            return AutoMapperConfig._mapper.Map<ClienteVM>(_cliente.Add(domain));
        }

        public ClienteVM Get(string id)
        {
            return AutoMapperConfig._mapper.Map<ClienteVM>(_cliente.Get(id));
        }

        public IEnumerable<ClienteVM> GetAll()
        {
            return AutoMapperConfig._mapper.Map<IEnumerable<ClienteVM>>(_cliente.GetAll());
        }

        public void Remove(string id)
        {
            _cliente.Remove(id);
        }

        public ClienteVM Update(ClienteVM cliente)
        {
            var domain = AutoMapperConfig._mapper.Map<Cliente>(cliente);
            return AutoMapperConfig._mapper.Map<ClienteVM>(_cliente.Update(domain));
        }
    }
}
