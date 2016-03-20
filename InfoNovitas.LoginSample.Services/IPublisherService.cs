using InfoNovitas.LoginSample.Services.Messaging.Publishers;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using System.Collections.Generic;

namespace InfoNovitas.LoginSample.Services
{
    public interface IPublisherService
    {
        GetPublishersResponse GetPublishers();
    }
}
