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
    
    public partial class ImportProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FolderName { get; set; }
        public int FileTypeId { get; set; }
        public int EntityTypeId { get; set; }
        public bool Enabled { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public bool UpdateOnly { get; set; }
        public string KeyFieldNames { get; set; }
        public string FileTypeConfiguration { get; set; }
        public string ExtraData { get; set; }
        public string ColumnMapping { get; set; }
        public string ResultInfo { get; set; }
        public int SchedulingTaskId { get; set; }
        public bool ImportRelatedData { get; set; }
    
        public virtual ScheduleTask ScheduleTask { get; set; }
    }
}
