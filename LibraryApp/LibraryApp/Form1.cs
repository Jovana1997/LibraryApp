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
using System.IO;
using MongoDB.Driver.GridFS;
namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
            tbNewPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Korisnik>("Korisnik");
            Korisnik korisnik = new Korisnik();
            korisnik.Ime = tbIme.Text;
            korisnik.Prezime = tbPrezime.Text;
            korisnik.Email = tbEmail.Text;
            korisnik.Username = tbNewUsername.Text;
            korisnik.Password = tbNewPassword.Text;
            collection.InsertOne(korisnik);
            MessageBox.Show("Successful");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Korisnik>("Korisnik");
            var filter = "{ Username: '" + tbUsername.Text + "', Password: '" + tbPassword.Text + "'}";
            if (collection.CountDocuments(filter) == 0)
            {
                MessageBox.Show("Ne postoji takav korisnik");
                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                foreach (Korisnik k in collection.Find(_ => true).ToList())
                { 
                    if (k.Username == tbUsername.Text && k.Password == tbPassword.Text)
                    {
                        Global.idKorisnika = k.Id;
                        Form2 f2 = new Form2(Global.idKorisnika);
                        f2.Show();
                    }
                    
                }
            }
        }
        public static class Global
        {
            public static ObjectId idKorisnika { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Dokument>("Dokument");
            Dokument dokument = new Dokument();

            var fs = new GridFSBucket(db);
            var id = UploadFile(fs);
            dokument.DocId = id;
            ObjectId idd = new ObjectId("5e459c8953df61f3e3cc60a7");
            dokument.Naziv = "Na Drini cuprija";
            dokument.Knjiga = idd;
            collection.InsertOne(dokument);


        }
        private static ObjectId UploadFile(GridFSBucket fs)
        {
            using (var s = File.OpenRead(@"C:\Users\38160\Desktop\Na Drini cuprija.pdf"))
            {
                var t = Task.Run<ObjectId>(() => {
                    return
                    fs.UploadFromStreamAsync("Na Drini cuprija.pdf", s);
                });

                return t.Result;
            }
        }
    }
}
