using System.ComponentModel.DataAnnotations;

namespace Blog.API.DTOS.Author
{
    public record AuthorDTO (string Id, string FirstName,  string LastName);
    public record CreateAuthorDTO ([Required] string FirstName, [Required] string LastName);

    public record UpdateAuthorDTO ([Required] string FirstName, [Required] string LastName);
}