using InfoNovitas.LoginSample.Services.Messaging.Books;
using InfoNovitas.LoginSample.Services.Messaging.Views.Books;
using System.Collections.Generic;

namespace InfoNovitas.LoginSample.Services
{
    public interface IBookService
    {
        GetBooksResponse GetBooks();
    }
}
