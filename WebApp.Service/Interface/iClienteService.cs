using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Service.ViewModels;

namespace WebApp.Service.Interface
{
    public interface iClienteService
    {
        ClienteVM Get(string id);
        IEnumerable<ClienteVM> GetAll();
        ClienteVM Add(ClienteVM cliente);
        ClienteVM Update(ClienteVM cliente);
        void Remove(string id);
    }
}
