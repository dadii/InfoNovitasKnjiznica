using InfoNovitas.LoginSample.Repositories;
using System;
using System.Collections.Generic;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using InfoNovitas.LoginSample.Services.Messaging.Publishers;
using InfoNovitas.LoginSample.Services.Mapping;

namespace InfoNovitas.LoginSample.Services.Impl
{
    public class PublisherService:IPublisherService
    {
        private IPublisherRepository _repository;
        public PublisherService(IPublisherRepository repository)
        {
            _repository = repository;
        }

        public GetPublishersResponse GetPublishers()
        {
            var response = new GetPublishersResponse();

            try
            {
                response.Publishers = _repository.FindAll().MapToPublishersView();
                response.Success = true;
            }
            catch (Exception ex) {
                response.Success = false;
                response.Publishers= new List<Publisher>();
            }

            return response;
        }
    }
}
