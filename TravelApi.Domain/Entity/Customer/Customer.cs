
using TravelApi.Domain.Common;

namespace TravelApi.Domain.Entity;
public class Customer
{
    public Customer() { }

    public Guid Id { get; private set; }
    public string? Title { get; private set; } = null;
    public string FirstName { get; private set; } = string.Empty;
    public string? MiddleNames { get; private set; } = null;
    public string LastName { get; private set; } = string.Empty;
    public EmailAddress EmailAddress { get; private set; }
    public DateTime DateOfBirth { get; private set; }

    public static Customer Create(string title, string firstName, string middleNames, string lastName, EmailAddress emailAddress, DateTime dob) => new()
    {
        Id = Guid.NewGuid(),
        Title = title,
        FirstName = firstName,
        MiddleNames = middleNames,
        LastName = lastName,
        EmailAddress = emailAddress,
        DateOfBirth = dob
    };

}
