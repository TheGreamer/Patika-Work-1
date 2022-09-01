using PatikaClassWork1.Core.DataAccess.Abstract;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.DataAccess.Abstract
{
    public interface IBookDal : IEfRepository<Book>
    {
    }
}