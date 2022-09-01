using PatikaClassWork1.Core.Entity.Abstract;

namespace PatikaClassWork1.Core.Entity.Concrete
{
    public class CoreEntity : ICoreEntity<int>
    {
        public int Id { get; set; }
        public bool Status { get; set; }
    }
}