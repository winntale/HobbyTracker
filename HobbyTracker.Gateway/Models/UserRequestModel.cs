namespace HobbyTracker.Gateway.Models;

public sealed record UserRequestModel
{
    public required string Name { get; init; }
    public required string Email { get; init; }
    public required string PasswordHash { get; init; }
}