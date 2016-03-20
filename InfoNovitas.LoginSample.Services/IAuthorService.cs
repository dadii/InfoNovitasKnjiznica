using InfoNovitas.LoginSample.Services.Messaging.Authors;
using InfoNovitas.LoginSample.Services.Messaging.Views.Authors;
using System.Collections.Generic;

namespace InfoNovitas.LoginSample.Services
{
    public interface IAuthorService
    {
        GetAuthorsResponse GetAuthors();
    }
}
