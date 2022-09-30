using MediatR;
using Microsoft.AspNetCore.Mvc;
using Personal.Blog.Application.Post.AddPost;
using Personal.Blog.Application.User.GetUserWithPosts;

namespace Personal.Blog.API.Controllers;

[ApiController]
[Route("api/v1/")]
public class BlogController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public BlogController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("user/{id}/post")]
    public async Task<IActionResult> GetUserWithPosts(int id)
    {
        var user = await _mediator.Send(new GetUserWithPostsQuery(id));
        return Ok(user);
    }
    
    [HttpPost("post")]
    public async Task<IActionResult> AddPost([FromBody] AddPostCommand post)
    {
        var id = await _mediator.Send(post);
        return Ok(id);
    }
}