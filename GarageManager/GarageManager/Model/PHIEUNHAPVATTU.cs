//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GarageManager.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUNHAPVATTU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAPVATTU()
        {
            this.CT_PNVT = new HashSet<CT_PNVT>();
        }
    
        public int MaPhieuNhap { get; set; }
        public Nullable<int> MaVatTu { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGiaNhap { get; set; }
        public Nullable<decimal> DonGiaBan { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNVT> CT_PNVT { get; set; }
    }
}
