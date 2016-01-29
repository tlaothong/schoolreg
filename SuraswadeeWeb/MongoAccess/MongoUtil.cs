using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SuraswadeeWeb.MongoAccess
{
    public class MongoUtil
    {
        private static IMongoClient _client;
        public static IMongoDatabase _database;

        public MongoUtil()
        {
            var connectionString = WebConfigurationManager.AppSettings["primaryConnectionString"];
            _client = new MongoClient(connectionString);
            var dbName = WebConfigurationManager.AppSettings["databaseName"];
            _database = _client.GetDatabase(dbName);
        }

        public static IMongoCollection<T> GetCollection<T>(string tableName)
        {
            return _database.GetCollection<T>(tableName);
        }
    }
}