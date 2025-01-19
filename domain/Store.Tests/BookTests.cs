using store;

namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);
            Assert.False(actual);

        }
        [Fact]
        public void IsIsbn_WithBlank_ReturnFalse()
        {
            bool actual = Book.IsIsbn("    ");
            Assert.False(actual);

        }
        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");
            Assert.False(actual);

        }
        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 0");
            Assert.True(actual);

        }
        [Fact]
        public void IsIsbn_WithIsbn13_ReturnTrue()
        {
            bool actual = Book.IsIsbn("ISBN 123-456-789 0123");
            Assert.True(actual);

        }
        [Fact]
        public void IsIsbn_WithTashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxxxISBN 123-456-789 0123   terew");
            Assert.False(actual);

        }
    }
}