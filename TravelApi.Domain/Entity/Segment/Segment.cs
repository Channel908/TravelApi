﻿
using TravelApi.Domain.Enums;

namespace TravelApi.Domain.Entity;

public class Segment 
{
    private Segment() { }
    public SegmentId Id { get; private set; }
    public TripId TripId { get; private set; }
    public ESegmentType SegmentType { get; private set; }
    public string SupplierCode { get; private set; }
    public string Origin { get; private set; }
    public string Destination { get; private set; }
    public DateTime DepartureDateTime { get; private set; }
    public DateTime ArrivalDateTime { get; private set; }
    public ECabinType CabinType { get; private set; }
    public string BookingClass { get; private set; }

    public static Segment Create(
        TripId tripId,
        ESegmentType segmentType,
        string supplierCode,
        string origin,
        string destination,
        DateTime departureDateTime,
        DateTime arrivalDateTime,
        ECabinType cabinType,
        string bookingClass)
        => new()
        {
            Id = new SegmentId(Guid.NewGuid()),
            TripId = tripId,
            SegmentType = segmentType,
            SupplierCode = supplierCode,
            Origin = origin,
            Destination = destination,
            DepartureDateTime = departureDateTime,
            ArrivalDateTime = arrivalDateTime,
            CabinType = cabinType,
            BookingClass = bookingClass
        };

}