using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryApp.Data
{
    public class Slika
    {
        public ObjectId Id { get; set; }
        public ObjectId Autor { get; set; }
        public ObjectId DocId { get; set; }
        public string Naziv { get; set; }
    }
}
