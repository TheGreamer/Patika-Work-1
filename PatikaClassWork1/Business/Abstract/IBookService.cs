using PatikaClassWork1.Core.Business.Abstract;
using PatikaClassWork1.DataAccess.Abstract;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.Business.Abstract
{
    public interface IBookService : ICoreService<Book, IBookDal>
    {
    }
}