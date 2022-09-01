using PatikaClassWork1.Core.Dto.Abstract;

namespace PatikaClassWork1.Dto.Concrete
{
    public class UpdateBook : ICoreUpdateDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}