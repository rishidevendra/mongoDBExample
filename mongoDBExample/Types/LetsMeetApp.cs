using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongoDBExample.Types
{
    public class LetsMeetApp
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public Guid Authkey { get; set; }
        public long MobileNumber { get; set; }
        public string Name { get; set; }
        public int Birthday { get; set; }
        public string BirthMonth { get; set; }
        [BsonIgnoreIfNull]
        public List<Interest> interests;
    }
}
