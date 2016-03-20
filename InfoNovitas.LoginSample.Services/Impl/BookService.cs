using InfoNovitas.LoginSample.Repositories;
using System;
using System.Collections.Generic;
using InfoNovitas.LoginSample.Services.Messaging.Views.Books;
using InfoNovitas.LoginSample.Services.Messaging.Books;
using InfoNovitas.LoginSample.Services.Mapping;

namespace InfoNovitas.LoginSample.Services.Impl
{
    public class BookService:IBookService
    {
        private IBookRepository _repository;
        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public GetBooksResponse GetBooks()
        {
            var response = new GetBooksResponse();

            try
            {
                response.Books = _repository.FindAll().MapToBooksView();
                response.Success = true;
            }
            catch (Exception ex) {
                response.Success = false;
                response.Books= new List<Book>();
            }

            return response;
        }
    }
}
