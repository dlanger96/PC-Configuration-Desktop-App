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
    
    public partial class Pohrana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pohrana()
        {
            this.Konfiguracije_Racunala = new HashSet<Konfiguracije_Racunala>();
        }
    
        public int Id_Pohrana { get; set; }
        public string Naziv_Diska { get; set; }
        public string Proizvodac_Diska { get; set; }
        public Nullable<int> Kapacitet_Diska { get; set; }
        public Nullable<decimal> Cijena_Diska { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Konfiguracije_Racunala> Konfiguracije_Racunala { get; set; }
    }
}