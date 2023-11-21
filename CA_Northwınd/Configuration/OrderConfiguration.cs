using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x=>x.ShipName).HasMaxLength(50);

            builder
                .HasOne(cu => cu.Customer)   
                .WithMany(o => o.Orders)     
                .HasForeignKey(x => x.CustomerId)      
                .OnDelete(DeleteBehavior.Restrict);

            builder
           .HasOne(e => e.Employees)
           .WithMany(e=>e.Orders)
           .HasForeignKey(x => x.EmployeeId)
           .OnDelete(DeleteBehavior.Restrict);


            builder
           .HasOne(s => s.Shipper)
           .WithMany(s=>s.Orders)
           .HasForeignKey(s => s.ShipVia)
           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
