using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelApi.Domain.Common;
using TravelApi.Domain.Entity;

namespace TravelApi.Persistence.Configurations;

internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .HasConversion(value => value.Value, value => new CustomerId(value));

        builder
            .Property(x => x.Title)
            .HasMaxLength(10);

        builder.Property(x=> x.FirstName)
            .HasMaxLength(25);

        builder.Property(x => x.LastName)
            .HasMaxLength(25);

        builder.Property(x => x.MiddleNames)
            .HasMaxLength(255);

        builder
            .HasIndex(x => new { x.FirstName, x.LastName })
            .HasDatabaseName("IX_Name");

        builder
            .Property(x => x.EmailAddress)
            .HasConversion(value => value.Value, value => new EmailAddress(value));

        builder.Property(x => x.EmailAddress)
            .HasMaxLength(50);

        builder
            .HasIndex(x => x.EmailAddress)
            .IsUnique();

   





    }
}
