using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryApp.Data
{
    public class Autor
    {
        public ObjectId Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mesto { get; set; }
        public string Biografija { get; set; }
        public List<MongoDBRef> Knjige { get; set; }
        public Autor()
        {
            Knjige = new List<MongoDBRef>();
        }
    }
}
