using System;
using System.Collections.Generic;
using System.Text;

namespace RiverBooks.Books
{
    public record BookDto(Guid Id, string Title, string Author);
}
