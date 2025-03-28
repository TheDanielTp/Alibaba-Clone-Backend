using AlibabaClone.Domain.Aggregates.AccountAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.AccountAggregates
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure (EntityTypeBuilder<Gender> builder)
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