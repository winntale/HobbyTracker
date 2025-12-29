using Core.Abstractions.Queries.Users.CommandModels;

namespace Core.Abstractions.Queries.Users;

public interface IUsersCommandOperations
{
    Task<Guid> Add(
        UserCommandModel newUser,
        CancellationToken ct);
}