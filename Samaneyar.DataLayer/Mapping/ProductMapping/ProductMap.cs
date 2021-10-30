using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Samaneyar.DataLayer.Shop.ProductAgg;

namespace Samaneyar.DataLayer.Mapping.ProductMapping
{
   public class ProductMap:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(500).IsRequired();
            builder.Property(x => x.PictureAlt).HasMaxLength(200).IsRequired();
            builder.Property(x => x.PictureTitle).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Keywords).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description1).IsRequired();
            builder.Property(x => x.Video1).HasMaxLength(500);
            builder.Property(x => x.MetaDescription).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();
            builder.Property(x => x.VideoTitle).HasMaxLength(500);
            builder.Property(x => x.Video2).HasMaxLength(500);
        }
    }
}
