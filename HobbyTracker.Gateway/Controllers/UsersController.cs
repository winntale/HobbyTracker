using AutoMapper;
using Core.Abstractions.Queries.Users;
using Core.Abstractions.Queries.Users.CommandModels;
using Core.Abstractions.Queries.Users.QueryModels;
using HobbyTracker.Gateway.Models;
using Microsoft.AspNetCore.Mvc;

namespace HobbyTracker.Gateway.Controllers;

[ApiController]
[Route("api/users")]
public sealed class UsersController(IMapper mapper)
    : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult<UserResultModel>> GetById(
        [FromServices] IGetUserOperations process,
        [FromRoute] Guid id,
        CancellationToken ct)
    {
        var result = await process.GetById(id, ct);
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> Add(
        [FromServices] IUsersCommandOperations process,
        [FromBody] UserRequestModel request,
        CancellationToken ct)
    {
        var queryModel = mapper.Map<UserCommandModel>(request);

        var result = await process.Add(queryModel, ct);
        return CreatedAtAction(nameof(GetById), new { id = result }, result);
    }
}