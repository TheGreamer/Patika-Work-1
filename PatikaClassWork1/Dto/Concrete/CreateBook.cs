using PatikaClassWork1.Core.Dto.Abstract;

namespace PatikaClassWork1.Dto.Concrete
{
    public class CreateBook : ICoreCreateDto
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}