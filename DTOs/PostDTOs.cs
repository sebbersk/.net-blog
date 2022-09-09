using System.ComponentModel.DataAnnotations;

namespace Blog.API.DTOS.Post
{
    public record PostDTO (string Id, string Title,  string Content,  string AuthorId, DateTimeOffset CreatedAt);
    public record CreatePostDTO ([Required] string Title, [Required] string Content, [Required] string AuthorId);

    public record UpdatePostDTO ([Required] string Title, [Required] string Content);
}