namespace VisProg7
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=firstCourseWork")
        {
        }

        public virtual DbSet<employers> employers { get; set; }
        public virtual DbSet<expences> expences { get; set; }
        public virtual DbSet<provider> provider { get; set; }
        public virtual DbSet<report> report { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
