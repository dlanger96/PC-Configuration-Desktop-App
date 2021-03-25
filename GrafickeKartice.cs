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
        public BindingList<Kuciste> DohvatiSveGRaficke()
        {
            BindingList<Kuciste> listaGrafickihKartica;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaGrafickihKartica = new BindingList<Kuciste>(entities.Graficka_Kartica.ToList());
            }
            return listaGrafickihKartica;
        }
    }
}
