using ReadingTime6.Web.Services;
using Xunit;

namespace ReadingTime6.Web.Tests.Unit
{
    public class BookServiceTests
    {
        [Fact]
        public void BookServiceCountTest()
        {
            BookService bookService = new BookService();
            Assert.Equal(6, actual: bookService.Books().Count);
        }
    }
}
