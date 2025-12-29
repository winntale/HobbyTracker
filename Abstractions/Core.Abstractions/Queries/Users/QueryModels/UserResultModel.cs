namespace Core.Abstractions.Queries.Users.QueryModels;

public sealed record UserResultModel
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Email { get; init; }
    public required string PasswordHash { get; init; }
}