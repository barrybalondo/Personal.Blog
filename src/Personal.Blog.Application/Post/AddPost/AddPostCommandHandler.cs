using MediatR;
using Personal.Blog.Application.Configuration.Command;
using Personal.Blog.Domain.SeedWork;

namespace Personal.Blog.Application.Post.AddPost;

internal sealed class AddPostCommandHandler : ICommandHandler<AddPostCommand, int>
{
    private readonly IUnitOfWork _unitOfWork;
    
    public AddPostCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(AddPostCommand request, CancellationToken cancellationToken)
    {
        var post = new Domain.Post.Post(request.UserId, request.Title, request.Body);
        await _unitOfWork.PostRepository.AddAsync(post);
        await _unitOfWork.SaveAsync();
        return post.Id;
    }
}