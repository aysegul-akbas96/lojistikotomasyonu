//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lojistik_Projesi__11Nisan2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firmalar()
        {
            this.AlıcıFirma = new HashSet<AlıcıFirma>();
            this.TaşıyıcıFirma = new HashSet<TaşıyıcıFirma>();
            this.ÜreticiFirma = new HashSet<ÜreticiFirma>();
            this.Departman = new HashSet<Departman>();
            this.Sevkiyat = new HashSet<Sevkiyat>();
        }
    
        public int FirmaID { get; set; }
        public string FirmaTipi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlıcıFirma> AlıcıFirma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaşıyıcıFirma> TaşıyıcıFirma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ÜreticiFirma> ÜreticiFirma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Departman> Departman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sevkiyat> Sevkiyat { get; set; }
    }
}
