using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racunala
{
    public partial class formKonfiguracijaRac : Form
    {
        KonfiguracijeRacunala konfiguracijeRacunala = new KonfiguracijeRacunala();
        GrafickeKartice graficke = new GrafickeKartice();
        Kucista kucista = new Kucista();
        Procesori procesori = new Procesori();
        Diskovi diskovi = new Diskovi();
        Ram ram = new Ram();
        MaticnePloce maticne = new MaticnePloce();
        Napajanja napajanja = new Napajanja();
        DataGridViewRow dgvRow;
        public formKonfiguracijaRac()
        {
            InitializeComponent();
            Dohvati();
            Napuni();
        }



        private void Dohvati()
        {
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                var nestedQuery = from konf in entities.Konfiguracije_Racunala
                                  from g in entities.Graficka_Kartica
                                  from k in entities.Kucistes
                                  from m in entities.Maticna_Ploca
                                  from n in entities.Napajanjes
                                  from d in entities.Pohranas
                                  from p in entities.Procesors
                                  from r in entities.Radna_Memorija
                                  where
g.Id_Graficke == konf.VK_Graficku && k.Id_Kucista == konf.VK_Kuciste && m.Id_Maticna_Ploca == konf.VK_Maticna && n.Id_Napajanje == konf.VK_Napajanje
&& d.Id_Pohrana == konf.VK_Pohranu && p.Id_Procesor == konf.VK_Procesor && r.Id_RAM == konf.VK_RAM
                                  select new
                                  {
                                      konf.Id_Konfiguracije,
                                      konf.Naziv_Konfiguracije,
                                      konf.Stanje_Na_Skladistu,
                                      konf.Cijena_Konfiguracije,
                                      g.Naziv__Graficke,
                                      k.Naziv_Kucista,
                                      m.Naziv_Maticne,
                                      n.Naziv_Napajanja,
                                      d.Naziv_Diska,
                                      p.Naziv_Procesora,
                                      r.Naziv_RAM
                                  };
                var result = nestedQuery.ToList();
                dgvKonfiguracija.DataSource = result;
            }
        }

        private void Napuni()
        {
            dgvGraficke.DataSource = graficke.DohvatiSveGRaficke();
            dgvKucista.DataSource = kucista.DohvatiSvaKucista();
            dgvMaticna.DataSource = maticne.DohvatiSveMaticne();
            dgvNapajanje.DataSource = napajanja.DohvatiSvaNapajanja();
            dgvPohrana.DataSource = diskovi.DohvatiSveDiskove();
            dgvProcesor.DataSource = procesori.DohvatiSveProcesore();
            dgvRam.DataSource = ram.DohvatiSveRam();
        }

        private void formKonfiguracijaRac_Load(object sender, EventArgs e)
        {

        }

        private void dgvGraficke_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = dgvGraficke.Rows[e.RowIndex];
            txtGraficka.Text = dgvRow.Cells[0].Value.ToString();

        }

        private void dgvKucista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = dgvKucista.Rows[e.RowIndex];
            txtKuciste.Text = dgvRow.Cells[0].Value.ToString();
        }

        private void dgvMaticna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = dgvRam.Rows[e.RowIndex];
            txtRam.Text = dgvRow.Cells[0].Value.ToString();
        }

        private void dgvNapajanje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = dgvNapajanje.Rows[e.RowIndex];
            txtNapajanje.Text = dgvRow.Cells[0].Value.ToString();
        }

        private void dgvPohrana_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = dgvPohrana.Rows[e.RowIndex];
            txtPohrana.Text = dgvRow.Cells[0].Value.ToString();
        }

        private void dgvProcesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMaticna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = dgvMaticna.Rows[e.RowIndex];
            txtMaticna.Text = dgvRow.Cells[0].Value.ToString();
        }

        private void dgvProcesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = dgvProcesor.Rows[e.RowIndex];
            txtProcesor.Text = dgvRow.Cells[0].Value.ToString();
        }

        private void btnDodajKonfig_Click(object sender, EventArgs e)
        {
            string nazivKonfig = txtNazivKonf.Text;
            int stanjeSkladista = int.Parse(txtStanjeKonf.Text);
            decimal cijenaKonfig = decimal.Parse(txtCijenaKonf.Text);
            int graficka = int.Parse(txtGraficka.Text);
            int kuciste = int.Parse(txtKuciste.Text);
            int napajanje = int.Parse(txtNapajanje.Text);
            int maticna = int.Parse(txtMaticna.Text);
            int pohrana = int.Parse(txtPohrana.Text);
            int procesor = int.Parse(txtProcesor.Text);
            int ram = int.Parse(txtRam.Text);

            konfiguracijeRacunala.UnesiKonfiguraciju(nazivKonfig, cijenaKonfig, stanjeSkladista, graficka, kuciste, maticna, napajanje, pohrana, procesor, ram);
            Dohvati();
        }
    }
}
