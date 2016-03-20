using InfoNovitas.LoginSample.Services.Messaging.Views.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services.Messaging.Users
{
    public class GetUsersResponse:LibraryResponseBase
    {
        public List<UserInfo> Users { get; set; }
    }
}
