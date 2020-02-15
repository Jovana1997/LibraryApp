using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


namespace LibraryApp.Data
{
    public class Knjiga
    {
        public ObjectId Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public double Ocena { get; set; }
        public List<MongoDBRef> Ocene { get; set; }
        public List<MongoDBRef> Komentari { get; set; }
        public ObjectId Autor { get; set; }
        public ObjectId Zanr { get; set; }
        public Knjiga()
        {
            Ocene = new List<MongoDBRef>();
            Komentari = new List<MongoDBRef>();
        }
    }
}
