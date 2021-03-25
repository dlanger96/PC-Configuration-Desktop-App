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
    public partial class formaProcesora : Form
    {
        Procesori procesori = new Procesori();
        public formaProcesora()
        {
            InitializeComponent();
            Osvjezi();
        }

        private void btnDodajProc_Click(object sender, EventArgs e)
        {
            string nazivProcesora = txtNazivProcesora.Text;
            int godinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text);
            string nazivProizvodaca = txtNazivProizvodaca.Text;
            decimal cijenaProcesora = decimal.Parse(txtCijenaProc.Text);
            int brojJezgri = int.Parse(txtBrojJezgri.Text);
            double taktProcesora = double.Parse(txtTaktProcesora.Text);
            procesori.unosProcesora(nazivProcesora, godinaProizvodnje, nazivProizvodaca, cijenaProcesora, brojJezgri, taktProcesora);
            MessageBox.Show("Podaci su spremljeni");

            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvProcesori.DataSource = procesori.DohvatiSveProcesore();
        }

        private void txtPretrazivanjeProc_TextChanged(object sender, EventArgs e)
        {
            dgvProcesori.DataSource= procesori.PretražiPoNazivuProcesora(txtPretrazivanjeProc.Text);
        }

        private void btnIzmjProc_Click(object sender, EventArgs e)
        {
            string nazivProcesora = txtIzmNazivProc.Text;
            int godinaProizvodnje = int.Parse(txtIzmGodProc.Text);
            string nazivProizvodaca = txtIzmNazivProizvod.Text;
            decimal cijenaProcesora = decimal.Parse(txtIzmCijena.Text);
            int brojJezgri = int.Parse(txtIzmBrojJezg.Text);
            double taktProcesora = double.Parse(txtIzmTaktProc.Text);

            Procesor odabraniProcesor = dgvProcesori.CurrentRow.DataBoundItem as Procesor;
            procesori.IzmjenaProcesora(odabraniProcesor, nazivProcesora, godinaProizvodnje, nazivProizvodaca, cijenaProcesora, brojJezgri, taktProcesora);
            Osvjezi();


        }

        private void dgvProcesori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvProcesori.Rows[e.RowIndex];
            txtIzmNazivProc.Text = dgvRow.Cells[1].Value.ToString();
            txtIzmGodProc.Text = dgvRow.Cells[3].Value.ToString();
            txtIzmNazivProizvod.Text = dgvRow.Cells[2].Value.ToString();
            txtIzmCijena.Text = dgvRow.Cells[6].Value.ToString();
            txtIzmBrojJezg.Text = dgvRow.Cells[4].Value.ToString();
            txtIzmTaktProc.Text = dgvRow.Cells[5].Value.ToString();

        }
    }
}
