using AlibabaClone.Domain.Aggregates.AccountAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlibabaClone.Infrastructure.Configurations.AccountAggregates
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure (EntityTypeBuilder<Person> builder)
        {
            builder.HasKey (x => x.Id);
            builder.Property (x => x.Id)
                .ValueGeneratedOnAdd ();

            builder.Property (x => x.FirstName)
                .IsRequired ()
                .HasMaxLength (64);

            builder.Property (x => x.LastName)
                .IsRequired ()
                .HasMaxLength (64);

            builder.Property (x => x.IdNumber)
                .IsRequired ()
                .HasMaxLength (32)
                .IsUnicode (false);
            builder.HasIndex (x => x.IdNumber).IsUnique ();

            builder.Property (x => x.PassportNumber)
                .HasMaxLength (32)
                .IsUnicode (false);

            builder.Property (x => x.EnglishFirstName)
                .HasMaxLength (64)
                .IsUnicode (false);

            builder.Property (x => x.EnglishLastName)
                .HasMaxLength (64)
                .IsUnicode (false);

            builder.Property (x => x.Birthdate)
                .HasColumnType ("date");

            builder.HasOne (x => x.Gender)
                .WithMany ()
                .HasForeignKey (p => p.GenderId)
                .OnDelete (DeleteBehavior.Restrict);
        }
    }
}