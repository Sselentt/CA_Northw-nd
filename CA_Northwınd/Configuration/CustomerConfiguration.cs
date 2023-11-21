using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.CompanyName).HasMaxLength(40).IsRequired();
            builder.Property(x => x.ContactName).HasMaxLength(40);
            builder.Property(x => x.ContactTitle).HasMaxLength(40);
            builder.Property(x => x.Address).HasMaxLength(250);


        }
    }
}
