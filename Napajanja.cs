using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunala
{
    class Napajanja
    {
        public BindingList<Napajanje> DohvatiSvaNapajanja()
        {
            BindingList<Napajanje> listaNapajanja;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaNapajanja = new BindingList<Napajanje>(entities.Napajanjes.ToList());
            }
            return listaNapajanja;
        }
    }
}
