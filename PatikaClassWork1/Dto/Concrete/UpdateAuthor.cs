using PatikaClassWork1.Core.Dto.Abstract;

namespace PatikaClassWork1.Dto.Concrete
{
    public class UpdateAuthor : ICoreUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}