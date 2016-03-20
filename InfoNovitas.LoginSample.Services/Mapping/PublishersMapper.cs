using AutoMapper;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services.Mapping
{
    public static class PublishersMapper
    {
        public static Publisher MapToPublisherView(this Repositories.DatabaseModel.Publisher model) {
            return Mapper.Map<Publisher>(model);
        }

        public static List<Publisher> MapToPublishersView(this List<Repositories.DatabaseModel.Publisher> models)
        {
            var result = new List<Publisher>();
            if (models == null)
                return result;
            result = models.Select(m => m.MapToPublisherView()).ToList();
            return result;
        }
    }
}
