using MongoDB.Driver;
using mongoDBExample.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongoDBExample
{
    public class LetsAppContext
    {
        private static IMongoDatabase db;
        public LetsAppContext()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.ConnectionMode = ConnectionMode.Automatic;
            MongoClient client = new MongoClient(settings);
           // settings. = ConnectionMode.Automatic;
            db = client.GetDatabase("LetsMeetAppDB");
        }

        public IMongoCollection<LetsMeetApp> collection
        {
            get
            {
                return db.GetCollection<LetsMeetApp>("LetsMeetApp");
            }
        }
    }
}
