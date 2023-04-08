namespace TravelApi.Domain.Entity;

public class Trip
{

    private Trip() { }

    private List<Segment> _segments = new();
    public IReadOnlyList<Segment> Segments => _segments.ToList();
    public TripId Id { get; private set; }
    public CustomerId CustomerId { get; private set; }
    public string TripName { get; private set; } = string.Empty;

    public static Trip Create(CustomerId customerId, string tripName) => new()
    {
        Id = new TripId(Guid.NewGuid()),
        CustomerId = customerId,
        TripName = tripName,
    };

    public void AddSegment(Segment segment)
    {
        _segments.Add(segment);
    }

}
