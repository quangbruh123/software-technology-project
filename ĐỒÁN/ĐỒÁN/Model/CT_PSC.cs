//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ĐỒÁN.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_PSC
    {
        public string MaCTPSC { get; set; }
        public string MaPhieuSC { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> SoLan { get; set; }
        public string MaTienCong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    
        public virtual PHIEUSUACHUA PHIEUSUACHUA { get; set; }
        public virtual TIENCONG TIENCONG { get; set; }
    }
}
