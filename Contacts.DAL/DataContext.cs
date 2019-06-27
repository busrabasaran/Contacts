namespace Contacts.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Contacts.Entity;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Persons>()
            //    .HasMany(e => e.Phones)
            //    .WithRequired(e => e.Persons)
            //    .WillCascadeOnDelete(false);
        }
    }
}
