using AutoMapper;
using Dal.Abstractions.Models;
using Dal.Abstractions.Repositories;
using HobbyTracker.Dal.Context;
using HobbyTracker.Dal.Entities;

namespace HobbyTracker.Dal.Repositories;

internal sealed class UserCommandRepository(
    ModelDbContext context,
    IMapper mapper)
    
    : IUserCommandRepository
{
    public async Task<Guid> Add(AddUserRepositoryModel user, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<User>(user);
        await context.Users.AddAsync(entity, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
        
        return entity.Id;
    }
}