using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunala
{
    class Diskovi
    {
        public BindingList<Pohrana> DohvatiSveDiskove()
        {
            BindingList<Pohrana> listaDiskova;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaDiskova = new BindingList<Pohrana>(entities.Pohranas.ToList());
            }
            return listaDiskova;
        }
    }
}
