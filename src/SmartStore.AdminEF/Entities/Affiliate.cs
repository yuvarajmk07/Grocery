//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartStore.AdminEF.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Affiliate
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
    
        public virtual Address Address { get; set; }
    }
}
