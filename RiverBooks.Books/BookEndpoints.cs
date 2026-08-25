using Microsoft.AspNetCore.Builder;

namespace RiverBooks.Books
{
    public static class BookEndpoints
    {
        public static void MapBookEndpoints(this WebApplication app)
        {
            var group = app.MapGet("/api/Book", (IBookService bookService) =>
            {
                return bookService.ListBooks();
            });
        }
    }
}
