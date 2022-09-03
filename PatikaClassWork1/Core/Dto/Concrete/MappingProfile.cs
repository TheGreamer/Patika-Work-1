using AutoMapper;
using PatikaClassWork1.Dto.Concrete;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.Core.Dto.Concrete
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<BookDto, Book>().ReverseMap();
        }
    }
}