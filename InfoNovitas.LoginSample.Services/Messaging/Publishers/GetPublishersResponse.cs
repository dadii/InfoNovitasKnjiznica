using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services.Messaging.Publishers
{
    public class GetPublishersResponse:LibraryResponseBase
    {
        public List<Publisher> Publishers { get; set; }
    }
}
