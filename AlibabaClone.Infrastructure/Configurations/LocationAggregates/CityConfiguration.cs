using AlibabaClone.Domain.Aggregates.LocationAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.LocationAggregates
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure (EntityTypeBuilder<City> builder)
        {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id)
                .ValueGeneratedOnAdd ();

            builder.Property (x => x.Title)
                .IsRequired ()
                .HasMaxLength (128);

            builder.HasIndex (x => x.Title)
                .IsUnique ();
        }
    }
}