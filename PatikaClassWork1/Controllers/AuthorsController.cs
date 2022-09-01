using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaClassWork1.Business.Abstract;
using PatikaClassWork1.Core.Api.Concrete;
using PatikaClassWork1.Dto.Concrete;
using PatikaClassWork1.Entity.Concrete;
using PatikaClassWork1.Utilities;

namespace PatikaClassWork1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : CoreController<Author, CreateAuthor, UpdateAuthor, IAuthorService>
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService service, IMapper mapper) : base(service, mapper)
        {
            _authorService = service;
        }

        [HttpDelete]
        public override async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return BadRequest(Message.ID_NULL);

            var author = await _authorService.GetById((int)id);

            if (author == null)
                return NotFound(Message.NOT_FOUND);

            return await _authorService.Delete(author)
                ? Ok(Message.DELETED)
                : BadRequest(Message.AUTHOR_DELETE_ERROR);
        }
    }
}