using AutoMapper;
using InfoNovitas.LoginSample.Services.Messaging.Views.Users;
using System.Collections.Generic;
using System.Linq;

namespace InfoNovitas.LoginSample.Services.Mapping
{
    public static class UserMapper
    {
        public static UserInfo MapToView(this Repositories.DatabaseModel.UserInfo model)
        {
            return Mapper.Map<UserInfo>(model);
        }

        public static UserInfo MapToUserView(this Repositories.DatabaseModel.UserInfo model)
        {
            return Mapper.Map<UserInfo>(model);
        }

        public static List<UserInfo> MapToUsersView(this List<Repositories.DatabaseModel.UserInfo> models)
        {
            var result = new List<UserInfo>();
            if (models == null)
                return result;
            result = models.Select(m => m.MapToUserView()).ToList();
            return result;
        }

    }
}
