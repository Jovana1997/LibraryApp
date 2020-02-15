using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using LibraryApp.Data;
using MongoDB.Driver.GridFS;
using System.IO;

namespace LibraryApp
{
    public partial class Form4 : Form
    {
        public Form4(string ime, string prezime)
        {
            InitializeComponent();
            Global.imeAutora = ime;
            Global.prezimeAutora = prezime;
            lIme.Text += ime;
            lPrezime.Text += prezime;
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Knjiga>("Knjiga");
            var collection1 = db.GetCollection<Autor>("Autor");
            var collection2 = db.GetCollection<Zanr>("Zanr");
            List<Autor> autor = collection1.Find(x => x.Ime == ime && x.Prezime == prezime).ToList();
            lMesto.Text += autor.First().Mesto;
            tbBiografija.Text = autor.First().Biografija;
            List<Knjiga> knjige = collection.Find(x => x.Autor == autor.First().Id).ToList();
            List<Zanr> zanrovi = new List<Zanr>();

            Table table = new Table();
            DataRow row;
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Naziv";
            table.nazivi.Columns.Add(column);
            DataColumn column1 = new DataColumn();
            column1.DataType = System.Type.GetType("System.String");
            column1.ColumnName = "Zanr";
            table.nazivi.Columns.Add(column1);
            foreach (Knjiga k in knjige)
            {
                row = table.nazivi.NewRow();
                row["Naziv"] = k.Naziv;
                zanrovi = collection2.Find(x => x.Id == k.Zanr).ToList();
                row["Zanr"] = zanrovi.First().Naziv;
                table.nazivi.Rows.Add(row);
            }
            dgvKnjige.DataSource = table.nazivi;

            var slikaColl = db.GetCollection<Slika>("Slika");
            List<Slika> slike = slikaColl.Find(x => x.Autor == autor.First().Id).ToList();
            var fs = new GridFSBucket(db);
            string naziv = autor.First().Ime + autor.First().Prezime;
            
            Image image = DownloadFile(fs, slike.First().DocId, naziv);
            pcAutor.SizeMode = PictureBoxSizeMode.Zoom;

            pcAutor.Image = image;
        }
        private static Image DownloadFile(GridFSBucket fs, ObjectId id, string naziv)
        {
            //This works
            var t = fs.DownloadAsBytesByNameAsync(naziv + ".jpg");
            Task.WaitAll(t);
            var bytes = t.Result;

            using (var newFs = new FileStream(naziv, FileMode.Create))
            {
                newFs.Write(bytes, 0, bytes.Length);
                Image image = Image.FromStream(newFs);
                return image;
               
            }

        }
        public static class Global
        {
            public static string imeAutora { get; set; }
            public static string prezimeAutora { get; set; }
        }
        public class Table
        {
            public DataTable nazivi;

            public Table()
            {
                nazivi = new DataTable("Knjige");
            }
        }
    }
}
