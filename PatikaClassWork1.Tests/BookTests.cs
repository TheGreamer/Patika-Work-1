using PatikaClassWork1.Business.Abstract;
using FluentAssertions;
using Xunit;
using Moq;

namespace PatikaClassWork1.Tests
{
    public class BookTests
    {
        private readonly Mock<IBookService> _bookService = new();

        [Fact]
        public void There_must_be_a_book_with_id_3()
        {
            _bookService.Object.GetById(4).Should().NotBeNull();
        }

        [Fact]
        public void At_least_2_books_exist()
        {
            _bookService.Object.GetAll().Result.Count.Should().BeGreaterThan(1);
        }
    }
}