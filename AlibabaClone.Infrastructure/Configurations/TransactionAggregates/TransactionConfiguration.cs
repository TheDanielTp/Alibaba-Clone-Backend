using AlibabaClone.Domain.Aggregates.TransactionAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.TransactionAggregates
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure (EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey (x => x.Id);

            builder.Property (x => x.TicketId)
                .IsRequired ();

            builder.Property (x => x.BaseAmount)
                .IsRequired ()
                .HasColumnType ("decimal(18,2)");

            builder.Property (x => x.FinalAmount)
                .IsRequired ()
                .HasColumnType ("decimal(18,2)");

            builder.Property (x => x.SerialNumber)
                .IsRequired ()
                .HasMaxLength (64)
                .IsUnicode (false);

            builder.Property (x => x.CreatedAt)
                .IsRequired ();

            builder.Property (x => x.CouponId)
                .IsRequired (false);

            builder.HasOne (x => x.Ticket)
                .WithMany ()
                .HasForeignKey (x => x.TicketId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}