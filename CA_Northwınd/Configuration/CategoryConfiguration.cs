using CA_Northwınd.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_Northwınd.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> Builder)
        {

            Builder.Property(x => x.CategoryName).HasMaxLength(255).IsRequired();
            Builder.Property(x => x.Description).HasMaxLength(500).IsRequired();

            List<Category> categories = new List<Category>
             {

            new Category
            {
                CategoryId = 1,
                CategoryName="Beverages",
                Description="Soft drinks, coffees, teas, beers, and ales"
            },

            new Category
            {
                CategoryId=2,
                CategoryName="Seafood",
                Description="Seaweed and fish"
            }

        };
           Builder.HasData(categories);


        }


    }
}
