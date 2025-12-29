namespace Core.Abstractions.Queries.Users.CommandModels;

public sealed record UserCommandModel
{
    public required string Name { get; init; }
    public required string Email { get; init; }
    public required string PasswordHash { get; init; }
}