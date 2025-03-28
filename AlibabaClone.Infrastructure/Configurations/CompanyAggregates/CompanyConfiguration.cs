using AlibabaClone.Domain.Aggregates.CompanyAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.CompanyAggregates
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure (EntityTypeBuilder<Company> builder)
        {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id)
                .ValueGeneratedOnAdd ();

            builder.Property (x => x.Title)
                .IsRequired ()
                .HasMaxLength (128);

            builder.HasIndex (x => x.Title)
                .IsUnique ();
        }
    }
}