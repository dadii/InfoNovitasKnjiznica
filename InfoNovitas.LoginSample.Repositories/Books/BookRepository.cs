using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Repositories.Books
{
    public class BookRepository : IBookRepository
    {
        public int Add(Book item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Book item)
        {
            throw new NotImplementedException();
        }

        public List<Book> FindAll()
        {
            using (var context = new IdentityExDbEntities())
            {
                return context.Books.Select(s=>s).ToList();
            }
        }

        public Book FindBy(int key)
        {
            throw new NotImplementedException();
        }

        public Book Save(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
