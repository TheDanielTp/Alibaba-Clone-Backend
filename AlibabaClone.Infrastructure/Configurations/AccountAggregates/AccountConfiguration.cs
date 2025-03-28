using AlibabaClone.Domain.Aggregates.AccountAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.AccountAggregates
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure (EntityTypeBuilder<Account> builder)
        {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id)
                .ValueGeneratedOnAdd ();

            builder.Property (x => x.PhoneNumber)
                .IsRequired ()
                .IsUnicode (false)
                .HasMaxLength (16);

            builder.Property (x => x.Password)
                .IsRequired ()
                .IsUnicode (false)
                .IsFixedLength (true)
                .HasMaxLength (64);

            builder.Property (x => x.Email)
                .IsUnicode (false)
                .HasMaxLength (255);

            builder.HasOne (x => x.Person)
                .WithMany (x => x.Accounts)
                .HasForeignKey (x => x.PersonId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}