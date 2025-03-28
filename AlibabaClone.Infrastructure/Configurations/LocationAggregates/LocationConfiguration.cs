using AlibabaClone.Domain.Aggregates.LocationAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.LocationAggregates
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure (EntityTypeBuilder<Location> builder)
        {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id)
                .ValueGeneratedOnAdd ();

            builder.Property (x => x.Title)
                .IsRequired ()
                .HasMaxLength (128);

            builder.Property (x => x.CityId)
                .IsRequired ();

            builder.Property (x => x.LocationTypeId)
                .IsRequired ();

            builder.HasOne (x => x.City)
                .WithMany (x => x.Locations)
                .HasForeignKey (x => x.CityId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.LocationType)
                .WithMany (x => x.Locations)
                .HasForeignKey (x => x.LocationTypeId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}