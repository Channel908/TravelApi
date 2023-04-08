using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelApi.Domain.Common;
using TravelApi.Domain.Entity;

namespace TravelApi.Persistence.Configurations;

internal class SegmentConfiguration : IEntityTypeConfiguration<Segment>
{
    public void Configure(EntityTypeBuilder<Segment> builder)
    {
        builder
     .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .HasConversion(value => value.Value, value => new SegmentId(value));

        builder
            .Property(x => x.SupplierCode)
            .HasMaxLength(10);

        builder
            .Property(x => x.Origin)
            .HasMaxLength(3);

        builder
            .Property(x => x.Destination)
            .HasMaxLength(3);

        builder
             .Property(x => x.BookingClass)
            .HasMaxLength(1);


    }
}
