using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.Property(x=>x.CompanyName).HasMaxLength(40);
            builder.Property(x=>x.PhoneNumber).HasColumnType("char(11)");


        }
    }
}
