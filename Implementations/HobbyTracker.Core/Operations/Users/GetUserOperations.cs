using AutoMapper;
using Core.Abstractions.Queries.Users;
using Core.Abstractions.Queries.Users.QueryModels;
using Dal.Abstractions.Repositories;

namespace HobbyTracker.Core.Operations.Users;

internal sealed class GetUserOperations(
    IUserQueryRepository repository,
    IMapper mapper)

    : IGetUserOperations
{
    public async Task<UserResultModel> GetById(Guid userId, CancellationToken ct)
    {
        var result = await repository.GetById(userId, ct);

        var resultModel = mapper.Map<UserResultModel>(result);
        return resultModel;
    }
}