using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Racunala
{
    class Procesori
    {
        public BindingList<Procesor> DohvatiSveProcesore()
        {
            BindingList<Procesor> listaProcesora;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaProcesora = new BindingList<Procesor>(entities.Procesors.ToList());
            }
            return listaProcesora;
        }

        public void unosProcesora(string naziv, int godina, string proizvodac, decimal cijena, int jezgre, double takt)
        {
            using (RacunalaEntities enteties = new RacunalaEntities())
            {
                Procesor procesor = new Procesor();
                procesor.Naziv_Procesora = naziv;
                procesor.Proizvodac_Procesora = proizvodac;
                procesor.Godina_Proizvodnje = godina;
                procesor.Broj_Jezgri = jezgre;
                procesor.Takt_Procesora = takt;
                procesor.Cijena_Procesora = cijena;

                enteties.Procesors.Add(procesor);
                enteties.SaveChanges();
            }
        }

        public BindingList<Procesor> PretražiPoNazivuProcesora(string nazivProcesora)
        {
            BindingList<Procesor> listaProcesoraPretrazivanje;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                //string sql = "SELECT * FROM Procesor WHERE Naziv_Procesora LIKE '"+ nazivProcesora +"%'";
                //istaProcesoraPretrazivanje = new BindingList<Procesor>(entities.Procesors.SqlQuery(sql).ToList());
                var upit = from p in entities.Procesors where p.Naziv_Procesora.Contains(nazivProcesora) select p;
                listaProcesoraPretrazivanje = new BindingList<Procesor>(upit.ToList());

            }
            return listaProcesoraPretrazivanje;
        }

        public void IzmjenaProcesora(Procesor odabraniProcesor, string naziv, int godina, string proizvodac, decimal cijena, int jezgre, double takt)
        {
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                entities.Procesors.Attach(odabraniProcesor);

                odabraniProcesor.Naziv_Procesora = naziv;
                odabraniProcesor.Naziv_Procesora = naziv;
                odabraniProcesor.Proizvodac_Procesora = proizvodac;
                odabraniProcesor.Godina_Proizvodnje = godina;
                odabraniProcesor.Broj_Jezgri = jezgre;
                odabraniProcesor.Takt_Procesora = takt;
                odabraniProcesor.Cijena_Procesora = cijena;

                entities.SaveChanges();

            }
        }

        


    }
}
