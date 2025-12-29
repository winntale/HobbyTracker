using Dal.Abstractions.Models;

namespace Dal.Abstractions.Repositories;

public interface IUserQueryRepository
{
    Task<UserRepositoryModel> GetById(Guid id, CancellationToken ct);
}