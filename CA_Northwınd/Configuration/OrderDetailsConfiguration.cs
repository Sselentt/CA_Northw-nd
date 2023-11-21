using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(x => x.UnitPrice).HasColumnType("money").IsRequired();
            builder.Property(x => x.Quentity).IsRequired();
            builder.Property(x => x.Discount).HasColumnType("float").IsRequired();

            builder.HasKey(x => new { x.OrderId });

            builder
            .HasOne(p =>p.Product)
            .WithMany(o=>o.OrderDetails)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
