namespace HobbyTracker.Dal.Entities;

public sealed record User
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Email { get; init; }
    public required string PasswordHash { get; init; }
}