using AlibabaClone.Domain.Aggregates.LocationAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.LocationAggregates
{
    public class LocationTypeConfiguration : IEntityTypeConfiguration<LocationType>
    {
        public void Configure (EntityTypeBuilder<LocationType> builder)
        {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id)
                .ValueGeneratedOnAdd ();

            builder.Property (x => x.Title)
                .IsRequired ()
                .HasMaxLength (64);

            builder.HasIndex (x => x.Title)
                .IsUnique ();
        }
    }
}