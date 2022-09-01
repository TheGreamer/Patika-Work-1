using PatikaClassWork1.Business.Abstract;
using PatikaClassWork1.Core.Business.Concrete;
using PatikaClassWork1.DataAccess.Abstract;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.Business.Concrete
{
    public class BookService : CoreService<Book, IBookDal>, IBookService
    {
        public BookService(IBookDal bookDal) : base(bookDal)
        {
        }
    }
}