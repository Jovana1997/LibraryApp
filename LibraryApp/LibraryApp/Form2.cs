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
    public partial class Form2 : Form
    {
        public Form2(ObjectId korisnik)
        {
            InitializeComponent();
            Global.idKorisnika = korisnik;
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Zanr>("Zanr");
            List<Zanr> zanrovi = collection.Find(_ => true).ToList();
            foreach(Zanr z in zanrovi)
            {
                cbZanr.Items.Add(z.Naziv);
            }
        }
        public static class Global
        {
            public static ObjectId idKorisnika { get; set; }
            public static string nazivKnjige { get; set; }
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

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Knjiga>("Knjiga");
            var collection1 = db.GetCollection<Autor>("Autor");
            var collection2 = db.GetCollection<Zanr>("Zanr");
            if (cbZanr.Text != "")
            {
                List<Zanr> zanr = collection2.Find(x => x.Naziv == cbZanr.Text).ToList();
                List<Knjiga> knjige = collection.Find(x => x.Zanr == zanr.First().Id).ToList();
                List<Autor> autori = new List<Autor>();


                Table table = new Table();
                DataRow row;
                DataColumn column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = "Naziv";
                table.nazivi.Columns.Add(column);
                DataColumn column1 = new DataColumn();
                column1.DataType = System.Type.GetType("System.String");
                column1.ColumnName = "Autor";
                table.nazivi.Columns.Add(column1);

                foreach (Knjiga k in knjige)
                {
                    row = table.nazivi.NewRow();
                    row["Naziv"] = k.Naziv;
                    autori = collection1.Find(x => x.Id == k.Autor).ToList();
                    row["Autor"] = autori.First().Ime + " " + autori.First().Prezime;
                    table.nazivi.Rows.Add(row);
                }
                dgv1.DataSource = table.nazivi;
            }
        }

        private void btnPrikaziAutor_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Knjiga>("Knjiga");
            var collection1 = db.GetCollection<Autor>("Autor");
            var collection2 = db.GetCollection<Zanr>("Zanr");
            if (tbAutorIme.Text != "" && tbAutorPrezime.Text != "")
            {
                List<Autor> autor = collection1.Find(x => x.Ime == tbAutorIme.Text && x.Prezime == tbAutorPrezime.Text).ToList();
                List<Zanr> zanrovi = new List<Zanr>();
                if (autor.Count == 1)
                {
                    List<Knjiga> knjige = collection.Find(x => x.Autor == autor.First().Id).ToList();
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
                    dgv1.DataSource = table.nazivi;
                }
                else
                {
                    MessageBox.Show("Ne postoji takav autor u nasoj bazi");
                    tbAutorIme.Clear();
                    tbAutorPrezime.Clear();
                }
            }
        }

        private void btnPrikaziKnjigu_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Knjiga>("Knjiga");
            List<Knjiga> knjiga = collection.Find(x => x.Naziv == tbKnjiga.Text).ToList();
            if (knjiga.Count == 1)
            {
                Global.nazivKnjige = tbKnjiga.Text;
                Form3 f3 = new Form3(Global.nazivKnjige, Global.idKorisnika);
                f3.Show();
            }
            else
            {
                MessageBox.Show("Ne postoji takva knjiga u nasoj bazi");
                tbKnjiga.Clear();
            }
        }

        private void btnPrikaziAutora_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Autor>("Autor");
            List<Autor> autor = collection.Find(x => x.Ime == tbIme.Text && x.Prezime == tbPrezime.Text).ToList();
            if (autor.Count == 1)
            {
                Global.imeAutora = tbIme.Text;
                Global.prezimeAutora = tbPrezime.Text;
                Form4 f4 = new Form4(Global.imeAutora, Global.prezimeAutora);
                f4.Show();
            }
            else
            {
                MessageBox.Show("Ne postoji takav autor u nasoj bazi");
                tbIme.Clear();
                tbPrezime.Clear();
            }
        }

        private void btnSkini_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Dokument>("Dokument");
            var collection1 = db.GetCollection<Knjiga>("Knjiga");

            List<Knjiga> knjiga = collection1.Find(x => x.Naziv == tbKnjiga.Text).ToList();
            List<Dokument> dokument = collection.Find(x => x.Naziv == knjiga.First().Naziv).ToList();
            var fs = new GridFSBucket(db);
            DownloadFile(fs, dokument.First().Id, tbKnjiga.Text);
            /*
             * Svi fajlovi i slike se vec nalaze u bazi. Ubaceni su preko aplikacije, ali je ta funkcija izbacena, 
             * jer se ne ukplapa u konecpciju aplikacije. 
             * Funkcija je izgledala ovako:
             * private void button1_Click(object sender, EventArgs e)
                {
                    var connectionString = "mongodb://localhost/?safe=true";
                    var client = new MongoClient(connectionString);
                    var db = client.GetDatabase("Library");
                    var collection = db.GetCollection<Dokument>("Dokument"); ili slika
                    Dokument dokument = new Dokument();

                    var fs = new GridFSBucket(db);
                    var id = UploadFile(fs);
                    dokument.DocId = id;
                    ObjectId idd = id Autora u bazi;
                    dokument.Naziv = "Naziv dela ili slike";
                    dokument.Knjiga = idd;
                    collection.InsertOne(dokument);
                }
                private static ObjectId UploadFile(GridFSBucket fs)
                {
                    using (var s = File.OpenRead(@"C:\Users\38160\Desktop\Naziv dela ili slike + ekstenzija"))
                    {
                        var t = Task.Run<ObjectId>(() => {
                            return
                            fs.UploadFromStreamAsync("Naziv dela ili slike + ekstenzija", s);
                    });

                    return t.Result;
                    }
                }
             */
        }
        private static async void DownloadFile(GridFSBucket fs, ObjectId id, string naziv)
        {
            
            byte[] content = await fs.DownloadAsBytesByNameAsync(naziv + ".pdf");
            
            File.WriteAllBytes(@"C:\Users\38160\Downloads" + naziv + ".pdf", content);
            System.Diagnostics.Process.Start(@"C:\Users\38160\Downloads" + naziv + ".pdf");
        }
    }
}
