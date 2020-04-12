using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DB.Interface;
using WebApp.Domain;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebApp.DB
{
    public class ClienteRepository : iClienteRepository
    {
        MongoDB<Cliente> _db = new MongoDB<Cliente>("Cliente");

        public Cliente Add(Cliente cliente)
        {
            _db.Collection.InsertOne(cliente);
            return cliente;
        }

        public Cliente Get(string id)
        {
            return _db.FindOne(f => f.id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _db.FindMany(f => !string.IsNullOrEmpty(f.id));
        }

        public void Remove(string id)
        {
            _db.Collection.DeleteMany(c=>c.id == id);
        }

        public Cliente Update(Cliente cliente)
        {
            FilterDefinitionBuilder<Cliente> filtro = new FilterDefinitionBuilder<Cliente>();
            _db.Collection.ReplaceOne(filtro.Where(c=>c.id == cliente.id), cliente);
            return cliente;
        }
    }
}
