using AlibabaClone.Domain.Aggregates.AccountAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.AccountAggregates
{
    public class AccountRoleConfiguration : IEntityTypeConfiguration<AccountRole>
    {
        public void Configure (EntityTypeBuilder<AccountRole> builder)
        {
            builder.HasKey (x => new { x.RoleId, x.AccountId });

            builder.HasOne<Account> ()
                .WithMany ()
                .HasForeignKey (x => x.AccountId)
                .OnDelete (DeleteBehavior.Restrict);

            builder.HasOne<Role> ()
                .WithMany ()
                .HasForeignKey (x => x.RoleId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}