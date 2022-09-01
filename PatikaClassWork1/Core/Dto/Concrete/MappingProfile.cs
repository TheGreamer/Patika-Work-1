using AutoMapper;
using PatikaClassWork1.Dto.Concrete;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.Core.Dto.Concrete
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Author, CreateAuthor>();
            CreateMap<CreateAuthor, Author>();

            CreateMap<Author, UpdateAuthor>();
            CreateMap<UpdateAuthor, Author>();

            CreateMap<Book, CreateBook>();
            CreateMap<CreateBook, Book>();

            CreateMap<Book, UpdateBook>();
            CreateMap<UpdateBook, Book>();
        }
    }
}