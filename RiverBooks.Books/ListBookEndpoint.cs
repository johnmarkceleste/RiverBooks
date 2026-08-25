using FastEndpoints;

namespace RiverBooks.Books
{
    internal class ListBookEndpoint (IBookService bookService) :
        EndpointWithoutRequest<ListBooksResponse>
    {
        private readonly IBookService _bookService = bookService;

        public override void Configure()
        {
            Get("/api/books");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct = default)
        {
            var books = _bookService.ListBooks();

            await SendAsync(new ListBooksResponse()
            {
                Books = books
            });
        }
    }
}
