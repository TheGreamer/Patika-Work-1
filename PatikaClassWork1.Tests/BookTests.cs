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
        public void GetBook()
        {
            _bookService.Object.GetById(3).Should().NotBeNull();
        }
    }
}