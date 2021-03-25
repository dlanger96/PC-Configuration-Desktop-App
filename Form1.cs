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
    public partial class Form1 : Form
    {
        KonfiguracijeRacunala konfiguracije = new KonfiguracijeRacunala();
        public Form1()
        {
            InitializeComponent();
            Dohvati();
            
        }

        private void btnProcesor_Click(object sender, EventArgs e)
        {
            formaProcesora formaProcesora = new formaProcesora();
            formaProcesora.Show();
        }

       
        public void Dohvati()
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
                dataGridView1.DataSource = result;
            }
        }

        private void btnKonfiguracija_Click(object sender, EventArgs e)
        {
            formKonfiguracijaRac formaKonfiguracije = new formKonfiguracijaRac();
            formaKonfiguracije.Show();
        }
    }
}
