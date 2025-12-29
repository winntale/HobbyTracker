using Core.Abstractions.Queries.Users.QueryModels;

namespace Core.Abstractions.Queries.Users;

public interface IGetUserOperations
{
    Task<UserResultModel> GetById(
        Guid id,
        CancellationToken ct);
}