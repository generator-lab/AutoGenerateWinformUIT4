//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Catalog
    {
        public Catalog()
        {
            this.CachePolicy = new HashSet<CachePolicy>();
            this.Catalog1 = new HashSet<Catalog>();
            this.Catalog11 = new HashSet<Catalog>();
            this.DataSets = new HashSet<DataSets>();
            this.DataSets1 = new HashSet<DataSets>();
            this.DataSource = new HashSet<DataSource>();
            this.ModelDrill = new HashSet<ModelDrill>();
            this.ModelDrill1 = new HashSet<ModelDrill>();
            this.ModelPerspective = new HashSet<ModelPerspective>();
            this.ReportSchedule = new HashSet<ReportSchedule>();
            this.Subscriptions = new HashSet<Subscriptions>();
        }
    
        public System.Guid ItemID { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public int Type { get; set; }
        public byte[] Content { get; set; }
        public Nullable<System.Guid> Intermediate { get; set; }
        public Nullable<System.Guid> SnapshotDataID { get; set; }
        public Nullable<System.Guid> LinkSourceID { get; set; }
        public string Property { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Hidden { get; set; }
        public System.Guid CreatedByID { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.Guid ModifiedByID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string MimeType { get; set; }
        public Nullable<int> SnapshotLimit { get; set; }
        public string Parameter { get; set; }
        public System.Guid PolicyID { get; set; }
        public bool PolicyRoot { get; set; }
        public int ExecutionFlag { get; set; }
        public Nullable<System.DateTime> ExecutionTime { get; set; }
        public string SubType { get; set; }
        public Nullable<System.Guid> ComponentID { get; set; }
    
        public virtual ICollection<CachePolicy> CachePolicy { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Catalog> Catalog1 { get; set; }
        public virtual Catalog Catalog2 { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual ICollection<Catalog> Catalog11 { get; set; }
        public virtual Catalog Catalog3 { get; set; }
        public virtual Policies Policies { get; set; }
        public virtual ICollection<DataSets> DataSets { get; set; }
        public virtual ICollection<DataSets> DataSets1 { get; set; }
        public virtual ICollection<DataSource> DataSource { get; set; }
        public virtual ICollection<ModelDrill> ModelDrill { get; set; }
        public virtual ICollection<ModelDrill> ModelDrill1 { get; set; }
        public virtual ICollection<ModelPerspective> ModelPerspective { get; set; }
        public virtual ICollection<ReportSchedule> ReportSchedule { get; set; }
        public virtual ICollection<Subscriptions> Subscriptions { get; set; }
    }
}
