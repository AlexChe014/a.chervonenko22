namespace VisProg9
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<author> author { get; set; }
        public virtual DbSet<book> book { get; set; }
        public virtual DbSet<buyer> buyer { get; set; }
        public virtual DbSet<publish> publish { get; set; }
        public virtual DbSet<purch_book> purch_book { get; set; }
        public virtual DbSet<purchase> purchase { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<book>()
                .HasMany(e => e.purch_book)
                .WithRequired(e => e.book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<publish>()
                .HasMany(e => e.purch_book)
                .WithRequired(e => e.publish)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<purchase>()
                .HasMany(e => e.purch_book)
                .WithRequired(e => e.purchase)
                .WillCascadeOnDelete(false);
        }
    }
}
