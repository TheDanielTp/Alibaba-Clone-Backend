using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.TransportationAggregates
{
    public class TransportationConfiguration : IEntityTypeConfiguration<Transportation>
    {
        public void Configure (EntityTypeBuilder<Transportation> builder)
        {
            builder.HasKey (x => x.Id);

            builder.Property (x => x.FromLocationId)
                .IsRequired ();

            builder.Property (x => x.ToLocationId)
                .IsRequired ();

            builder.Property (x => x.CompanyId)
                .IsRequired ();

            builder.Property (x => x.VehicleId)
                .IsRequired ();

            builder.Property (x => x.StartDateTime)
                .IsRequired ();

            builder.Property (x => x.EndDateTime)
                .IsRequired ();

            builder.Property (x => x.SerialNumber)
                .IsRequired ()
                .HasMaxLength (64)
                .IsUnicode (false);

            builder.Property (x => x.RemainingCapacity)
                .IsRequired ();

            builder.Property (x => x.BasePrice)
                .HasColumnType ("decimal(18,2)")
                .IsRequired ();

            builder.Property (x => x.VIPPrice)
                .HasColumnType ("decimal(18,2)");

            builder.HasOne (x => x.FromLocation)
                .WithMany (x => x.DepartingTransportations)
                .HasForeignKey (x => x.FromLocationId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.ToLocation)
                .WithMany (x => x.ArrivingTransportations)
                .HasForeignKey (x => x.ToLocationId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.Company)
                .WithMany (x => x.Transportations)
                .HasForeignKey (x => x.CompanyId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.Vehicle)
                .WithMany (x => x.Transportations)
                .HasForeignKey (x => x.VehicleId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}