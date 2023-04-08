namespace TravelApi.Domain.Entity;

public class Trip
{

    private Trip() { }

    private List<Segment> _segments = new();
    public IReadOnlyList<Segment> Segments => _segments.ToList();
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public string TripName { get; private set; } = string.Empty;

    public static Trip Create(Guid customerId, string tripName) => new()
    {
        Id = Guid.NewGuid(),
        CustomerId = customerId,
        TripName = tripName,
    };

    public void AddSegment(Segment segment)
    {
        _segments.Add(segment);
    }

}
