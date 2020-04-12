using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service
{
    public class DatabaseConfigure
    {
        public DatabaseConfigure(string connectionString, params string[] collections)
        {
            WebApp.DB.MongoDBConfig.Configure(connectionString, collections);
        }
    }
}
