using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(x => x.CompanyName).HasMaxLength(40).IsRequired();
            builder.Property(x => x.ContactName).HasMaxLength(40);
            builder.Property(x=>x.ContactTitle).HasMaxLength(40);
            builder.Property(x=>x.Address).HasMaxLength(250);
            
            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier
                {
                    SupplierId = 1,
                    CompanyName="Mayumi's",
                    ContactName="Mayumi Ohno",
                    ContactTitle="Marketing Representative",
                    Address="92 Setsuko Chuo-ku"
                }

            };
        builder.HasData(suppliers);

        }
    }
}
