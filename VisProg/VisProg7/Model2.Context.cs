﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisProg7
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class driveCourseEntities : DbContext
    {
        public driveCourseEntities()
            : base("name=driveCourseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<auto> auto { get; set; }
        public virtual DbSet<objects> objects { get; set; }
        public virtual DbSet<payment> payment { get; set; }
        public virtual DbSet<s_group> s_group { get; set; }
        public virtual DbSet<users> users { get; set; }
    }
}
