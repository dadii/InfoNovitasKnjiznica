using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Repositories.Publishers
{
    public class PublisherRepository : IPublisherRepository
    {
        public int Add(Publisher item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Publisher item)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> FindAll()
        {
            using (var context = new IdentityExDbEntities())
            {
                return context.Publishers.Select(s=>s).ToList();
            }
        }

        public Publisher FindBy(int key)
        {
            throw new NotImplementedException();
        }

        public Publisher Save(Publisher item)
        {
            throw new NotImplementedException();
        }
    }
}
