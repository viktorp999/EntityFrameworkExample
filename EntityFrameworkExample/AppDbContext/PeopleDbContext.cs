using System.Data.Entity;

namespace EntityFrameworkExample.AppDbContext
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext()
            :base("name=PeopleConnection")
        {

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PeopleDbConfig());
        }
    }
}
