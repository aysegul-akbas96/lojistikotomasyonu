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
    
    public partial class Ürünler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ürünler()
        {
            this.Sevkiyat = new HashSet<Sevkiyat>();
        }
    
        public int ÜrünID { get; set; }
        public string ÜrünAdı { get; set; }
        public int StokMiktar { get; set; }
        public string ÜrünTipi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sevkiyat> Sevkiyat { get; set; }
    }
}
