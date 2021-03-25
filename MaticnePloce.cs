using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racunala
{
    class MaticnePloce
    {
        public BindingList<Maticna_Ploca> DohvatiSveMaticne()
        {
            BindingList<Maticna_Ploca> listaMaticnih;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaMaticnih = new BindingList<Maticna_Ploca>(entities.Maticna_Ploca.ToList());
            }
            return listaMaticnih;
        }
    }
}
