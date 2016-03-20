using InfoNovitas.LoginSample.Repositories;
using System;
using System.Collections.Generic;
using InfoNovitas.LoginSample.Services.Messaging.Views.Authors;
using InfoNovitas.LoginSample.Services.Messaging.Authors;
using InfoNovitas.LoginSample.Services.Mapping;

namespace InfoNovitas.LoginSample.Services.Impl
{
    public class AuthorService:IAuthorService
    {
        private IAuthorRepository _repository;
        public AuthorService(IAuthorRepository repository)
        {
            _repository = repository;
        }

        public GetAuthorsResponse GetAuthors()
        {
            var response = new GetAuthorsResponse();

            try
            {
                response.Authors = _repository.FindAll().MapToAuthorsView();
                response.Success = true;
            }
            catch (Exception ex) {
                response.Success = false;
                response.Authors= new List<Author>();
            }

            return response;
        }
    }
}
