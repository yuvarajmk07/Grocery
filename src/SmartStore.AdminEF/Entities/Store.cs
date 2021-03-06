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
    
    public partial class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool SslEnabled { get; set; }
        public string SecureUrl { get; set; }
        public string Hosts { get; set; }
        public int LogoMediaFileId { get; set; }
        public int DisplayOrder { get; set; }
        public string HtmlBodyId { get; set; }
        public string ContentDeliveryNetwork { get; set; }
        public int PrimaryStoreCurrencyId { get; set; }
        public int PrimaryExchangeRateCurrencyId { get; set; }
        public bool ForceSslForAllPages { get; set; }
        public Nullable<int> FavIconMediaFileId { get; set; }
        public Nullable<int> PngIconMediaFileId { get; set; }
        public Nullable<int> AppleTouchIconMediaFileId { get; set; }
        public Nullable<int> MsTileImageMediaFileId { get; set; }
        public string MsTileColor { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Currency Currency1 { get; set; }
    }
}
