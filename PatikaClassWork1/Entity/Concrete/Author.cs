using PatikaClassWork1.Core.Entity.Concrete;
using System.Text.Json.Serialization;

namespace PatikaClassWork1.Entity.Concrete
{
    public class Author : CoreEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        [JsonIgnore]
        public List<Book> Books { get; set; }
    }
}