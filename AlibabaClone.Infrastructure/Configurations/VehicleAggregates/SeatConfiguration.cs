using AlibabaClone.Domain.Aggregates.VehicleAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.VehicleAggregates
{
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure (EntityTypeBuilder<Seat> builder)
        {
            builder.HasKey (x => x.Id);

            builder.Property (x => x.VehicleId)
                .IsRequired ();

            builder.Property (x => x.Row)
                .IsRequired ();

            builder.Property (x => x.Column)
                .IsRequired ();

            builder.Property (x => x.IsVIP)
                .IsRequired ();

            builder.Property (x => x.IsAvailable)
                .IsRequired ();

            builder.Property (x => x.Description)
                .HasMaxLength (256);

            builder.HasOne (x => x.Vehicle)
                .WithMany (x => x.Seats)
                .HasForeignKey (x => x.VehicleId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}