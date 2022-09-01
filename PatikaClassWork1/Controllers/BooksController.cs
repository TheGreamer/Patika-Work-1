using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PatikaClassWork1.Business.Abstract;
using PatikaClassWork1.Core.Api.Concrete;
using PatikaClassWork1.Dto.Concrete;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : CoreController<Book, CreateBook, UpdateBook, IBookService>
    {
        public BooksController(IBookService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}