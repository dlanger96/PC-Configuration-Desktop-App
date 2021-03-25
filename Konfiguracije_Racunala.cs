//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Racunala
{
    using System;
    using System.Collections.Generic;
    
    public partial class Konfiguracije_Racunala
    {
        public int Id_Konfiguracije { get; set; }
        public string Naziv_Konfiguracije { get; set; }
        public Nullable<decimal> Cijena_Konfiguracije { get; set; }
        public Nullable<int> Stanje_Na_Skladistu { get; set; }
        public Nullable<int> VK_Graficku { get; set; }
        public Nullable<int> VK_Kuciste { get; set; }
        public Nullable<int> VK_Maticna { get; set; }
        public Nullable<int> VK_Napajanje { get; set; }
        public Nullable<int> VK_Pohranu { get; set; }
        public Nullable<int> VK_Procesor { get; set; }
        public Nullable<int> VK_RAM { get; set; }
    
        public virtual Kuciste Graficka_Kartica { get; set; }
        public virtual Kuciste Kuciste { get; set; }
        public virtual Maticna_Ploca Maticna_Ploca { get; set; }
        public virtual Napajanje Napajanje { get; set; }
        public virtual Pohrana Pohrana { get; set; }
        public virtual Procesor Procesor { get; set; }
        public virtual Radna_Memorija Radna_Memorija { get; set; }
    }
}
