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
    
    public partial class MessageTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BccEmailAddresses { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsActive { get; set; }
        public int EmailAccountId { get; set; }
        public bool LimitedToStores { get; set; }
        public bool SendManually { get; set; }
        public Nullable<int> Attachment1FileId { get; set; }
        public Nullable<int> Attachment2FileId { get; set; }
        public Nullable<int> Attachment3FileId { get; set; }
        public string To { get; set; }
        public string ReplyTo { get; set; }
        public string ModelTypes { get; set; }
        public string LastModelTree { get; set; }
    }
}
