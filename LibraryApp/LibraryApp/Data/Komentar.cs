using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryApp.Data
{
    public class Komentar
    {
        public ObjectId Id { get; set; }
        public string KomentarText { get; set; }
        public ObjectId Knjiga { get; set; }
        public ObjectId Korisnik { get; set; }
    }
}
