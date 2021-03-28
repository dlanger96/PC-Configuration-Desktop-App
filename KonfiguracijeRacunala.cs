using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Racunala
{
    class KonfiguracijeRacunala
    {
       
        public void UnesiKonfiguraciju(string naziv, decimal cijena, int stanje, int graficka, int kuciste, int maticna, int napajanje, int disk, int procesor, int ram)
        {
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                Konfiguracije_Racunala konfig = new Konfiguracije_Racunala();

                konfig.Naziv_Konfiguracije = naziv;
                konfig.Cijena_Konfiguracije = cijena;
                konfig.Stanje_Na_Skladistu = stanje;
                konfig.VK_Graficku = graficka;
                konfig.VK_Kuciste = kuciste;
                konfig.VK_Maticna = maticna;
                konfig.VK_Napajanje = napajanje;
                konfig.VK_Pohranu = disk;
                konfig.VK_Procesor = procesor;
                konfig.VK_RAM = ram;

                entities.Konfiguracije_Racunala.Add(konfig);
                entities.SaveChanges();

            }
        }

        public void AzurirajKonfiguraciju(Konfiguracije_Racunala odabranaKonfiguracija, string naziv, decimal cijena, int stanje, int graficka, int kuciste, int maticna, int napajanje, int disk, int procesor, int ram)
        {
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                entities.Konfiguracije_Racunala.Attach(odabranaKonfiguracija);

                odabranaKonfiguracija.Naziv_Konfiguracije = naziv;
                odabranaKonfiguracija.Cijena_Konfiguracije = cijena;
                odabranaKonfiguracija.Stanje_Na_Skladistu = stanje;
                odabranaKonfiguracija.VK_Graficku = graficka;
                odabranaKonfiguracija.VK_Kuciste = kuciste;
                odabranaKonfiguracija.VK_Maticna = maticna;
                odabranaKonfiguracija.VK_Napajanje = napajanje;
                odabranaKonfiguracija.VK_Pohranu = disk;
                odabranaKonfiguracija.VK_Procesor = procesor;
                odabranaKonfiguracija.VK_RAM = ram;

                entities.SaveChanges();

            }
        }

        
        
    }
}
