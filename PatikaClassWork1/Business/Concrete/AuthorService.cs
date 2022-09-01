using PatikaClassWork1.Business.Abstract;
using PatikaClassWork1.Core.Business.Concrete;
using PatikaClassWork1.DataAccess.Abstract;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.Business.Concrete
{
    public class AuthorService : CoreService<Author, IAuthorDal>, IAuthorService
    {
        private readonly IBookDal _bookDal;

        public AuthorService(IAuthorDal authorDal, IBookDal bookDal) : base(authorDal)
        {
            _bookDal = bookDal;
        }

        public override async Task<bool> Delete(Author entity)
        {
            var books = await _bookDal.GetAll(b => b.AuthorId == entity.Id);

            if (books.Count > 0)
                return false;

            return await base.Delete(entity);
        }
    }
}