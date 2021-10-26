using System.Data.Entity;

namespace BTL_QLCHTT.Models
{
    public partial class QLCHTTDbContext : DbContext
    {

        public QLCHTTDbContext()
            : base("name=QLCHTTDbContext")
        {
        }

      
        public virtual DbSet<Person> Persons { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.PersonID)
                .IsUnicode(false);
        }
    }
}