using AutoMapper;
using PatikaClassWork1.Dto.Concrete;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.Core.Dto.Concrete
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<AuthorDto, Author>();

            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
        }
    }
}