using PatikaClassWork1.Core.DataAccess.Concrete;
using PatikaClassWork1.DataAccess.Abstract;
using PatikaClassWork1.DataAccess.Concrete.Contexts;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.DataAccess.Concrete.Layers
{
    public class AuthorDal : EfRepository<Author, EfContext>, IAuthorDal
    {
    }
}