using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x=>x.LastName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(250);
            builder.Property(x => x.City).HasMaxLength(50);

        }
    }
}
