using System.Data.Entity.ModelConfiguration;

namespace EntityFrameworkExample.AppDbContext
{
    public class PeopleDbConfig : EntityTypeConfiguration<Person>
    {
        public PeopleDbConfig()
        {
            HasKey(c => c.Id);

            Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(255);

            Property(c => c.Years)
                .IsRequired();
        }
    }
}
