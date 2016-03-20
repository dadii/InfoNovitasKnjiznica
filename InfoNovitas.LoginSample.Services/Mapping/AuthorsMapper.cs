using AutoMapper;
using InfoNovitas.LoginSample.Services.Messaging.Views.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services.Mapping
{
    public static class AuthorsMapper
    {
        public static Author MapToAuthorView(this Repositories.DatabaseModel.Author model) {
            return Mapper.Map<Author>(model);
        }

        public static List<Author> MapToAuthorsView(this List<Repositories.DatabaseModel.Author> models)
        {
            var result = new List<Author>();
            if (models == null)
                return result;
            result = models.Select(m => m.MapToAuthorView()).ToList();
            return result;
        }
    }
}
