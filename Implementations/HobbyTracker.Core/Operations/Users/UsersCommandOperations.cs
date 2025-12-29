using AutoMapper;
using Core.Abstractions.Queries.Users;
using Core.Abstractions.Queries.Users.CommandModels;
using Dal.Abstractions.Models;
using Dal.Abstractions.Repositories;

namespace HobbyTracker.Core.Operations.Users;

internal sealed class UsersCommandOperations(
    IUserCommandRepository repository,
    IMapper mapper)

    : IUsersCommandOperations
{
    public async Task<Guid> Add(UserCommandModel newUser, CancellationToken ct)
    {
        var addModel = mapper.Map<AddUserRepositoryModel>(newUser);

        var result = await repository.Add(addModel, ct);
        return result;
    }
}