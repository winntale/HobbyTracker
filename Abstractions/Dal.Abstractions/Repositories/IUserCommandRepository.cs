using Dal.Abstractions.Models;

namespace Dal.Abstractions.Repositories;

public interface IUserCommandRepository
{
    Task<Guid> Add(AddUserRepositoryModel user, CancellationToken ct);
}