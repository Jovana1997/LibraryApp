using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryApp.Data
{
    public class Zanr
    {
        public ObjectId Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public List<MongoDBRef> Knjige { get; set; }
        public Zanr()
        {
            Knjige = new List<MongoDBRef>();
        }
    }
}
