using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.DB
{
    public class MongoDBConfig
    {
        public static string DataBaseName = "WebAppDatabase";
        public static MongoClient cliente;
        public static IMongoDatabase DataBase;
        public static string ConnectionString;

        public static void Configure(string connectionString, params string[] collections)
        {
            ConnectionString = connectionString;
            cliente = new MongoClient(ConnectionString);
            DataBase = cliente.GetDatabase(DataBaseName);
            var collectionsDB = DataBase.ListCollectionNames().ToList();
            foreach (string collection in collections) 
            {
                if (!collectionsDB.Exists(e => e == collection))
                    DataBase.CreateCollection(collection);
            }
        }
    }
}
