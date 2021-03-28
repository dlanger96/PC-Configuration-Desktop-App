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
    public partial class formSkladiste : Form
    {
        Skladista skladista = new Skladista();
        public formSkladiste()
        {
            InitializeComponent();
            Prikazi();
        }

        private void Napuni()
        {
            dataGridView1.DataSource = skladista.DohvatiSvaSkladista();

           
        }

        private void Prikazi()
        {
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                var upit = from s in entities.Skladiste
                           from k in entities.Konfiguracije_Racunala
                           where s.Vk_Konfiguracija == k.Id_Konfiguracije
                           select new { k.Naziv_Konfiguracije, k.Cijena_Konfiguracije, s.Datum_evidencije, s.Trenutno_Stanje, s.Staro_Stanje, s.Pozicija };
                dataGridView1.DataSource = upit.ToList();
            }
        }


    }
}
