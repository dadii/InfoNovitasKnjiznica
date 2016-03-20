using AutoMapper;
using InfoNovitas.LoginSample.Services.Messaging.Views.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services.Mapping
{
    public static class BooksMapper
    {
        public static Book MapToBookView(this Repositories.DatabaseModel.Book model) {
            return Mapper.Map<Book>(model);
        }

        public static List<Book> MapToBooksView(this List<Repositories.DatabaseModel.Book> models)
        {
            var result = new List<Book>();
            if (models == null)
                return result;
            result = models.Select(m => m.MapToBookView()).ToList();
            return result;
        }
    }
}
