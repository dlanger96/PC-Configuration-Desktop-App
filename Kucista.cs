using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunala
{
    class Kucista
    {
        public BindingList<Kuciste> DohvatiSvaKucista()
        {
            BindingList<Kuciste> listaKucista;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaKucista = new BindingList<Kuciste>(entities.Kucistes.ToList());
            }
            return listaKucista;
        }
    }
}
