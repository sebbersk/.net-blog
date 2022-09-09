using Blog.API.Models;

namespace Blog.API.Interfaces
{
    public interface IAuthorRepo
    {
       void CreateAuthor(Author author);
       Author GetAuthor(string id);
       void UpdateAuthor(Author author);

       void DeleteAuthor(string id);
    }
}