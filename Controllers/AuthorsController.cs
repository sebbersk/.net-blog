using Blog.API.DTOS.Author;
using Blog.API.Extensions;
using Blog.API.Interfaces;
using Blog.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AuthorsController : ControllerBase
    {

        private readonly IAuthorRepo _authorRepo;
        private readonly ILogger _logger;

        public AuthorsController(IAuthorRepo authorRepo, ILogger<PostsController> logger) 
        {
            this._authorRepo = authorRepo;
            this._logger = logger;
        }


        [HttpPost]
        
        public ActionResult<AuthorDTO> CreateAuthor(CreateAuthorDTO createdAuthor) 
        {
            Author newAuthor = new Author{FirstName = createdAuthor.FirstName, LastName=createdAuthor.LastName};
            _authorRepo.CreateAuthor(newAuthor);
            return newAuthor.asDTO();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<AuthorDTO> GetAuthor(string id)
        {
            var author = _authorRepo.GetAuthor(id);
            
            if (author is null) {
                return NotFound();
            }
            return author.asDTO();
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult UpdateAuthor(string id, UpdateAuthorDTO authorDTO) 
        {
            var author = _authorRepo.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            author.FirstName = authorDTO.FirstName;
            author.LastName = authorDTO.LastName;
            _authorRepo.UpdateAuthor(author);
            
            return Content("Author Updated");
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteAuthor(string id)
        {
            var author = _authorRepo.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            _authorRepo.DeleteAuthor(id);           
            
            return Content("Author Deleted");
        }
    }
}