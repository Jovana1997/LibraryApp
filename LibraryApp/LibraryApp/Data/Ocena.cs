using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryApp.Data
{
    public class Ocena
    {
        public ObjectId Id { get; set; }
        public int OcenaBroj { get; set; }
        public ObjectId Knjiga { get; set; }
        public ObjectId Korisnik { get; set; }
    }
}
