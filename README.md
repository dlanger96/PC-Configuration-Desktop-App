# PC-Configuration-Desktop-App

## Desktop konfiguracijska aplikacija

Desktop aplikacija koja omogućuje korisniku izbor konfiguracija za njegovo računalo.

## Entity Framework

Database First approach
<img align="center" alt="ERA"  src="https://raw.githubusercontent.com/dlanger96/PC-Configuration-Desktop-App/main/Slike/devenv_8yCo8XqWGh.png"/>

## Ispis podataka iz tablice

Ispis se radi tako da se dohvate svi podaci u zadanoj tablici i pohrane kao lista.

```csharp
public BindingList<Procesor> DohvatiSveProcesore()
        {
            BindingList<Procesor> listaProcesora;
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                listaProcesora = new BindingList<Procesor>(entities.Procesors.ToList());
            }
            return listaProcesora;
        }
```

## Unos podataka u zadanu tablicu

```csharp
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
```

## Pretraživanje unutar tablice po željenom stupcu

```csharp
 public BindingList<Procesor> PretražiPoNazivuProcesora(string nazivProcesora)
        {
            BindingList<Procesor> listaProcesoraPretrazivanje;
            using (RacunalaEntities entities = new RacunalaEntities())
            {

                var upit = from p in entities.Procesors where p.Naziv_Procesora.Contains(nazivProcesora) select p;
                listaProcesoraPretrazivanje = new BindingList<Procesor>(upit.ToList());

            }
            return listaProcesoraPretrazivanje;
        }
```

## Izmjena podataka unutar zadane tablice

```csharp
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
```

## Korištenje LINQ kako bi se prikazala središnja tablica Konfiguracije računala

Spajanje vanjskih ključeva i ispis podataka koje korisnika zanimaju, a ne samo broje ključa.

```csharp
private void Dohvati()
        {
            using (RacunalaEntities entities = new RacunalaEntities())
            {
                var nestedQuery = from konf in entities.Konfiguracije_Racunala
                                  from g in entities.Graficka_Kartica
                                  from k in entities.Kucistes
                                  from m in entities.Maticna_Ploca
                                  from n in entities.Napajanjes
                                  from d in entities.Pohranas
                                  from p in entities.Procesors
                                  from r in entities.Radna_Memorija
                                  where
g.Id_Graficke == konf.VK_Graficku && k.Id_Kucista == konf.VK_Kuciste && m.Id_Maticna_Ploca == konf.VK_Maticna && n.Id_Napajanje == konf.VK_Napajanje
&& d.Id_Pohrana == konf.VK_Pohranu && p.Id_Procesor == konf.VK_Procesor && r.Id_RAM == konf.VK_RAM
                                  select new
                                  {
                                      konf.Id_Konfiguracije,
                                      konf.Naziv_Konfiguracije,
                                      konf.Stanje_Na_Skladistu,
                                      konf.Cijena_Konfiguracije,
                                      g.Naziv__Graficke,
                                      k.Naziv_Kucista,
                                      m.Naziv_Maticne,
                                      n.Naziv_Napajanja,
                                      d.Naziv_Diska,
                                      p.Naziv_Procesora,
                                      r.Naziv_RAM
                                  };
                var result = nestedQuery.ToList();
                dgvKonfiguracija.DataSource = result;
            }
        }
```
