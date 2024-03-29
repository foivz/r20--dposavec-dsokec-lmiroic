//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sloj_pristupa_podacima
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artikl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artikl()
        {
            this.Artikli_na_skladistu = new HashSet<Artikli_na_skladistu>();
            this.Stavke_dokumenta = new HashSet<Stavke_dokumenta>();
        }
    
        public int id_artikl { get; set; }
        public int godina_proizvodnje { get; set; }
        public Nullable<int> emisija_vozila { get; set; }
        public Nullable<int> snaga_vozila { get; set; }
        public string opis_artikla { get; set; }
        public Nullable<int> vrsta_goriva { get; set; }
        public string naziv_artikla { get; set; }
        public double cijena_artikla { get; set; }
        public int vrsta_artikla { get; set; }
        public int vrijeme_dostave { get; set; }
        public int minimalna_kolicina { get; set; }
    
        public virtual Vrste_artikla Vrste_artikla { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Artikli_na_skladistu> Artikli_na_skladistu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavke_dokumenta> Stavke_dokumenta { get; set; }
    }
}
