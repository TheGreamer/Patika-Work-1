using PatikaClassWork1.Core.Entity.Concrete;
using System.Text.Json.Serialization;

namespace PatikaClassWork1.Entity.Concrete
{
    public class Book : CoreEntity
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }

        [JsonIgnore]
        public Author Author { get; set; }
    }
}