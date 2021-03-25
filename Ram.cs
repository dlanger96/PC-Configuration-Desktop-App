using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunala
{
    class Ram
    {
        public BindingList<Radna_Memorija> DohvatiSveRam()
        {
            BindingList<Radna_Memorija> listaRam;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaRam = new BindingList<Radna_Memorija>(entities.Radna_Memorija.ToList());
            }
            return listaRam;
        }
    }
}
