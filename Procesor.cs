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
    
    public partial class Procesor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Procesor()
        {
            this.Konfiguracije_Racunala = new HashSet<Konfiguracije_Racunala>();
        }
    
        public int Id_Procesor { get; set; }
        public string Naziv_Procesora { get; set; }
        public string Proizvodac_Procesora { get; set; }
        public Nullable<int> Godina_Proizvodnje { get; set; }
        public Nullable<int> Broj_Jezgri { get; set; }
        public Nullable<double> Takt_Procesora { get; set; }
        public Nullable<decimal> Cijena_Procesora { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Konfiguracije_Racunala> Konfiguracije_Racunala { get; set; }
    }
}
