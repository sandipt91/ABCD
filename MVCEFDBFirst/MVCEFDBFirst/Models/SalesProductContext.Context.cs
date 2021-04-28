﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCEFDBFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SPEntityContext : DbContext
    {
        public SPEntityContext()
            : base("name=SPEntityContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<order_items> order_items { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<store> stores { get; set; }
        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }
        public virtual DbSet<spt_fallback_db> spt_fallback_db { get; set; }
        public virtual DbSet<spt_fallback_dev> spt_fallback_dev { get; set; }
        public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
        public virtual DbSet<spt_monitor> spt_monitor { get; set; }
        public virtual DbSet<spt_values> spt_values { get; set; }
    
        public virtual int sp_MScleanupmergepublisher()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MScleanupmergepublisher");
        }
    
        public virtual int sp_MSrepl_startup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MSrepl_startup");
        }
    }
}
