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
    
    public partial class warrantyActivityFee
    {
        public int id { get; set; }
        public string productSKU { get; set; }
        public int quantity { get; set; }
        public int activityID { get; set; }
        public double fixingfee { get; set; }
        public Nullable<bool> active { get; set; }
    
        public virtual tb_warranty_activities tb_warranty_activities { get; set; }
    }
}
