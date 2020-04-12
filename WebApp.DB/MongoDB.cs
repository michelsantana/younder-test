using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace WebApp.DB
{
    public class MongoDB<T> where T : class
    {
        static IMongoDatabase _db { get; set; }
        IMongoDatabase DataBase
        {
            get
            {
                if (_db == null)
                    _db = MongoDBConfig.DataBase;
                return _db;
            }
        }

        public IMongoCollection<T> Collection
        {
            get
            {
                return DataBase.GetCollection<T>(collectionInstanceName);
            }
        }

        string conexaoMongoDB { get; set; }

        string collectionInstanceName { get; set; }

        public MongoDB(string collectionName)
        {
            conexaoMongoDB = MongoDBConfig.ConnectionString;
            collectionInstanceName = collectionName;
            DataBase.GetCollection<T>(collectionInstanceName);
        }

        public T FindOne(Expression<Func<T, bool>> f)
        {
            try
            {
                var r = this.Collection.Find(f);
                if (r == null) return null;
                if (r.CountDocuments() == 0) return null;
                return r.First();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<T> FindMany(Expression<Func<T, bool>> f)
        {
            try
            {
                var r = this.Collection.Find(f);
                if (r == null) return null;
                if (r.CountDocuments() == 0) return null;
                return r.ToEnumerable();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }   
}
