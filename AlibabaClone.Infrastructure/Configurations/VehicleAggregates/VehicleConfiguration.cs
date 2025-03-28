using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.VehicleAggregates
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure (EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id)
                .ValueGeneratedOnAdd ();

            builder.Property (x => x.Title)
                .IsRequired ()
                .HasMaxLength (128);

            builder.Property (x => x.VehicleTypeId)
                .IsRequired ();

            builder.Property (x => x.Capacity)
                .IsRequired ();

            builder.Property (x => x.PlateNumber)
                .IsRequired ()
                .HasMaxLength (50);
            builder.HasIndex (x => x.PlateNumber).IsUnique ();

            builder.HasOne (x => x.VehicleType)
                .WithMany (x => x.Vehicles)
                .HasForeignKey (x => x.VehicleTypeId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}