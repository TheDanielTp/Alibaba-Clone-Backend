using AlibabaClone.Domain.Aggregates.TransportationAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.TransportationAggregates
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure (EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey (x => x.Id);

            builder.Property (x => x.TransportationId)
                .IsRequired ();

            builder.Property (x => x.SeatId)
                .IsRequired ();

            builder.Property (x => x.BuyerId)
                .IsRequired ();

            builder.Property (x => x.TravelerId)
                .IsRequired ();

            builder.Property (x => x.CreatedAt)
                .IsRequired ();

            builder.Property (x => x.CompanionId)
                .IsRequired (false);

            builder.Property (x => x.TicketStatusId)
                .IsRequired ();

            builder.Property (x => x.SerialNumber)
                .IsRequired ()
                .HasMaxLength (64)
                .IsUnicode (false);

            builder.Property (x => x.Description)
                .HasMaxLength (255)
                .IsUnicode (false);

            builder.HasOne (x => x.Transportation)
                .WithMany (x => x.Tickets)
                .HasForeignKey (x => x.TransportationId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.Seat)
                .WithMany (x => x.Tickets)
                .HasForeignKey (x => x.SeatId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.Buyer)
                .WithMany (x => x.BoughtTickets)
                .HasForeignKey (x => x.BuyerId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.Traveler)
                .WithMany (x => x.TraveledTickets)
                .HasForeignKey (x => x.TravelerId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.Companion)
                .WithMany ()
                .HasForeignKey (x => x.CompanionId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne (x => x.TicketStatus)
                .WithMany ()
                .HasForeignKey (x => x.TicketStatusId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}