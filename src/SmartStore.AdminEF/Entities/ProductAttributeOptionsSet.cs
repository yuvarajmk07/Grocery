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
    
    public partial class ProductAttributeOptionsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductAttributeOptionsSet()
        {
            this.ProductAttributeOptions = new HashSet<ProductAttributeOption>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductAttributeId { get; set; }
    
        public virtual ProductAttribute ProductAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductAttributeOption> ProductAttributeOptions { get; set; }
    }
}
