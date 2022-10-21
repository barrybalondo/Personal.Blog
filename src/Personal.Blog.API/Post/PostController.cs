using MediatR;
using Microsoft.AspNetCore.Mvc;
using Personal.Blog.Application.Post.AddPost;

namespace Personal.Blog.API.Post;

[ApiController]
[Route("api/v1/")]
public class PostController : ControllerBase
{
    private readonly IMediator _mediator;

    public PostController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("post")]
    public async Task<IActionResult> AddPost([FromBody] AddPostRequest request)
    {
        var addPostCommand = new AddPostCommand(request.UserId, request.Title, request.Body);
        var id = await _mediator.Send(addPostCommand);
        return Ok(id);
    }
}