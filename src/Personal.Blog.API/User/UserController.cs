using MediatR;
using Microsoft.AspNetCore.Mvc;
using Personal.Blog.Application.User.GetUserWithPosts;

namespace Personal.Blog.API.User;

[ApiController]
[Route("api/v1/")]
public class UserController: ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("user/{id}/post")]
    public async Task<IActionResult> GetUserWithPosts(int id)
    {
        var user = await _mediator.Send(new GetUserWithPostsQuery(id));
        return Ok(user);
    }
}