using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunala
{
    class GrafickeKartice
    {
        public BindingList<Graficka_Kartica> DohvatiSveGRaficke()
        {
            BindingList<Graficka_Kartica> listaGrafickihKartica;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaGrafickihKartica = new BindingList<Graficka_Kartica>(entities.Graficka_Kartica.ToList());
            }
            return listaGrafickihKartica;
        }
    }
}
