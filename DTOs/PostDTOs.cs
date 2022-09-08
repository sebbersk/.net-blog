using System.ComponentModel.DataAnnotations;

namespace Blog.API.DTOS.Post
{
    public record PostDTO (Guid Id, string Title,  string Content,  Guid AuthorId, DateTimeOffset CreatedAt);
    public record CreatePostDTO ([Required] string Title, [Required] string Content, [Required] Guid AuthorId);
}