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
    
    public partial class TaşıyıcıFirma
    {
        public int TaşıyıcıFirmaID { get; set; }
        public string Adı { get; set; }
        public string Adres { get; set; }
        public int Telefon { get; set; }
        public string TaşımaŞekli { get; set; }
        public int FirmalarFirmaID { get; set; }
    
        public virtual Firmalar Firmalar { get; set; }
    }
}
