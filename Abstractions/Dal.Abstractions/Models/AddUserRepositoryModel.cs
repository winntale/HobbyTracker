namespace Dal.Abstractions.Models;

public sealed record AddUserRepositoryModel
{
    public required string Name { get; init; }
    public required string Email { get; init; }
    public required string PasswordHash { get; init; }
}