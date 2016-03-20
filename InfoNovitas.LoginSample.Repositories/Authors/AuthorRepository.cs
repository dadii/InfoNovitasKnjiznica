using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Repositories.Authors
{
    public class AuthorRepository : IAuthorRepository
    {
        public int Add(Author item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Author item)
        {
            throw new NotImplementedException();
        }

        public List<Author> FindAll()
        {
            using (var context = new IdentityExDbEntities())
            {
                return context.Authors.Select(s=>s).ToList();
            }
        }

        public Author FindBy(int key)
        {
            throw new NotImplementedException();
        }

        public Author Save(Author item)
        {
            throw new NotImplementedException();
        }
    }
}
