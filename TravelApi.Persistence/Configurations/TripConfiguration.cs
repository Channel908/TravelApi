using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelApi.Domain.Common;
using TravelApi.Domain.Entity;

namespace TravelApi.Persistence.Configurations;

internal class TripConfiguration : IEntityTypeConfiguration<Trip>
{
    public void Configure(EntityTypeBuilder<Trip> builder)
    {
        builder
          .HasKey(t => t.Id);

        // Field definitions & conversions
        builder
            .Property(x => x.Id)
            .HasConversion(value => value.Value, value => new TripId(value));

        builder
            .Property(x => x.TripName)
            .HasMaxLength(50);

        builder
            .HasOne<Customer>()
            .WithMany()
            .HasForeignKey(x => x.CustomerId)
            .IsRequired();

        builder
            .HasMany(x => x.Segments)
            .WithOne()
            .HasForeignKey(x => x.TripId);
    }
}
