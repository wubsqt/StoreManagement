//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreAccounting.DataLayer.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Nullable<int> ShopingList { get; set; }
    
        public virtual Products Products { get; set; }
    }
}