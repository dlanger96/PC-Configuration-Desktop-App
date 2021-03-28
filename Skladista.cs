using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Racunala
{
    class Skladista
    {
        public BindingList<Skladiste> DohvatiSvaSkladista()
        {
            BindingList<Skladiste> listaSkladista;

            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaSkladista = new BindingList<Skladiste>(entities.Skladiste.ToList());
            }
            return listaSkladista;
        }

       
        

    }
}
