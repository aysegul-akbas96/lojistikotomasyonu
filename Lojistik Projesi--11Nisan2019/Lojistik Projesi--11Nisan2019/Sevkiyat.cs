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
    
    public partial class Sevkiyat
    {
        public int SevkiyatID { get; set; }
        public string SevkAdı { get; set; }
        public string Ülke { get; set; }
        public int ÜrünlerÜrünID { get; set; }
        public int FirmalarFirmaID { get; set; }
    
        public virtual Ürünler Ürünler { get; set; }
        public virtual Firmalar Firmalar { get; set; }
    }
}
