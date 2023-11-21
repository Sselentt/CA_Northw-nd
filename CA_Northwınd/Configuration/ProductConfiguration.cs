using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x=>x.ProductName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.UnitPrice).HasColumnType("money");
            builder.Property(x => x.UnitStock).HasColumnType("smallint");

            builder
                .HasOne(ca => ca.Category)   //bir tane neyi olur
                .WithMany(p => p.Products)     //birden fazla neyi olur
                .HasForeignKey(x => x.CategoryId)       //ilişkilendirdiğimiz ikincil anahtarı belli eder
                .OnDelete(DeleteBehavior.Restrict);     //eğer ürünlere verilmiş kategori, kategori tablosundan silimeye                                                    çalışıldığında hata vermesini sağlar

            builder
            .HasOne(ca => ca.Supplier)
            .WithMany(p=>p.Products)     
            .HasForeignKey(x => x.SupplierId)       
            .OnDelete(DeleteBehavior.Restrict);




            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    SupplierId=1,
                    CategoryId=1,
                    ProductName="Tofu",
                    UnitPrice=23.2500m,
                    UnitStock=35
                },
                new Product
                {
                    Id=2,
                    SupplierId=1,
                    CategoryId=2,
                    ProductName="Mascarpone Fabioli",
                    UnitPrice=32.0000m,
                    UnitStock=9
                }
            };
            builder.HasData(products);
           


        }
    }
}
