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
    
    public partial class Rule
    {
        public int Id { get; set; }
        public int RuleSetId { get; set; }
        public string RuleType { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public int DisplayOrder { get; set; }
    
        public virtual RuleSet RuleSet { get; set; }
    }
}