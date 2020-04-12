using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;

namespace WebApp.DB.Interface
{
    public interface iClienteRepository
    {
        Cliente Get(string id);
        IEnumerable<Cliente> GetAll();
        Cliente Add(Cliente cliente);
        Cliente Update(Cliente cliente);
        void Remove(string id);
    }
}
