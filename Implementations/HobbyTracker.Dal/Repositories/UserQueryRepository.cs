using AutoMapper;
using Dal.Abstractions.Models;
using Dal.Abstractions.Repositories;
using HobbyTracker.Dal.Context;
using Microsoft.EntityFrameworkCore;

namespace HobbyTracker.Dal.Repositories;

internal sealed class UserQueryRepository(
    ModelDbContext context,
    IMapper mapper)
    
    : IUserQueryRepository
{
    public async Task<UserRepositoryModel> GetById(Guid id, CancellationToken ct)
    {
        var entity = await context.Users
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken: ct);

        var resultModel = mapper.Map<UserRepositoryModel>(entity);

        return resultModel;
    }
}