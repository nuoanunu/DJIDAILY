//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace djiDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderDetail
    {
        public int id { get; set; }
        public string productDetailID { get; set; }
        public string Quantity { get; set; }
        public string ChietKhauPhanTram { get; set; }
        public string ChietKhauTrucTiep { get; set; }
        public string SoLuong { get; set; }
        public int orderID { get; set; }
        public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public string TempName { get; set; }
        public string QuiCach { get; set; }
        public Nullable<bool> warrantyAvailable { get; set; }
    
        public virtual order order { get; set; }
    }
}
