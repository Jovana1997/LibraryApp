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

namespace LibraryApp
{
    public partial class Form3 : Form
    {
        public Form3(string naziv, ObjectId korisnik)
        {
            InitializeComponent();
            dgvKomentari.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvKomentari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Global.nazivKnjige = naziv;
            Global.korisnikId = korisnik;
            for(int i=1; i<=10; i++)
            {
                cbOcena.Items.Add(i);
            }

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Knjiga>("Knjiga");
            List<Knjiga> knjiga = collection.Find(x => x.Naziv == Global.nazivKnjige).ToList();
            lNaziv.Text += Global.nazivKnjige;
            var collection1 = db.GetCollection<Autor>("Autor");
            List<Autor> autor = collection1.Find(x => x.Id == knjiga.First().Autor).ToList();
            lAutor.Text += autor.First().Ime + " " + autor.First().Prezime;
            var collection2 = db.GetCollection<Zanr>("Zanr");
            List<Zanr> zanr = collection2.Find(x => x.Id == knjiga.First().Zanr).ToList();
            lZanr.Text += zanr.First().Naziv;
            tbOpis.Text = knjiga.First().Opis;

            
            var collectionKorisnik = db.GetCollection<Korisnik>("Korisnik");
            List<Korisnik> korisnici = new List<Korisnik>();
            var collectionKomentar = db.GetCollection<Komentar>("Komentar");
            List<Komentar> komentari = collectionKomentar.Find(x => x.Knjiga == knjiga.First().Id).ToList();

            Table table = new Table();
            DataRow row;
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Komentar";
            table.komentari.Columns.Add(column);
            DataColumn column1 = new DataColumn();
            column1.DataType = System.Type.GetType("System.String");
            column1.ColumnName = "Korisnik";
            table.komentari.Columns.Add(column1);

            foreach (Komentar k in komentari)
            {
                row = table.komentari.NewRow();
                row["Komentar"] = k.KomentarText;
                korisnici = collectionKorisnik.Find(x => x.Id == k.Korisnik).ToList();
                row["Korisnik"] = korisnici.First().Username;
                table.komentari.Rows.Add(row);
            }
            dgvKomentari.DataSource = table.komentari;

            var collectionOcene = db.GetCollection<Ocena>("Ocena");
            List<Ocena> ocene = collectionOcene.Find(x => x.Knjiga == knjiga.First().Id).ToList();
            double prosek = ProsecnaOcena(ocene);
            prosek = Math.Round(prosek, 2);
            knjiga.First().Ocena = prosek;
            var update = new UpdateDefinitionBuilder<Knjiga>().Set(x => x.Ocena, prosek);
            collection.UpdateOne(x => x.Id == knjiga.First().Id, update);
            lOcena.Text += " " + knjiga.First().Ocena.ToString();
        }
        public static class Global
        {
            public static ObjectId korisnikId;
            public static string nazivKnjige;
        }
        public class Table
        {
            public DataTable komentari;

            public Table()
            {
                komentari = new DataTable("Knjige");
            }
        }

        private void btnKomentarisi_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Knjiga>("Knjiga");
            List<Knjiga> knjiga = collection.Find(x => x.Naziv == Global.nazivKnjige).ToList();
            var collection1 = db.GetCollection<Komentar>("Komentar");
            Komentar komentar = new Komentar();
            komentar.KomentarText = tbKomentar.Text;
            komentar.Knjiga = knjiga.First().Id;
            komentar.Korisnik = Global.korisnikId;
            if (tbKomentar.Text != "")
            {
                collection1.InsertOne(komentar);
                MessageBox.Show("Uspesno ste komentarisali knjigu");
                Form3 f3 = new Form3(Global.nazivKnjige, Global.korisnikId);
                f3.Show();
                this.Close();
            }
            else
                MessageBox.Show("Unesite komentar");
        }

        private void btnOceni_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Library");
            var collection = db.GetCollection<Knjiga>("Knjiga");
            var collection1 = db.GetCollection<Ocena>("Ocena");
            List<Knjiga> knjiga = collection.Find(x => x.Naziv == Global.nazivKnjige).ToList();
            List<Ocena> ocene = collection1.Find(x => x.Knjiga == knjiga.First().Id).ToList();
            bool ocenjeno = false;
            foreach(Ocena o in ocene)
            {
                if (o.Korisnik == Global.korisnikId)
                {
                    MessageBox.Show("Vec ste ocenili ovi knjigu");
                    ocenjeno = true;
                }
            }
            if (!ocenjeno && cbOcena.Text != "")
            {
                Ocena ocena = new Ocena();
                ocena.Knjiga = knjiga.First().Id;
                ocena.Korisnik = Global.korisnikId;
                ocena.OcenaBroj = Convert.ToInt32(cbOcena.Text);
                collection1.InsertOne(ocena);
                MessageBox.Show("Uspesno ste ocenili knjigu");
                Form3 f3 = new Form3(Global.nazivKnjige, Global.korisnikId);
                this.Close();
                f3.Show();
            }
            else MessageBox.Show("Unesite ocenu");
            
      
        }
        public double ProsecnaOcena(List<Ocena> ocene)
        {
            if (ocene.Count != 0)
            {
                double prosek = 0;
                foreach (Ocena o in ocene)
                {
                    prosek += o.OcenaBroj;
                }
                prosek = prosek / ocene.Count();
                return prosek;
            }
            else return 0;
        }
    }
}
