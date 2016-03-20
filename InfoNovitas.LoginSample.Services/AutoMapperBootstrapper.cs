using AutoMapper;
using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using InfoNovitas.LoginSample.Services.Messaging.Views.Users;
using InfoNovitas.LoginSample.Services.Messaging.Views.Authors;
using InfoNovitas.LoginSample.Services.Messaging.Views.Books;
using Model = InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Services
{
    public class AutoMapperBootstrapper
    {
        public static void CreateMap()
        {

           Mapper.CreateMap<UserInfo, Model.UserInfo>().ForMember(x => x.User, opt => opt.Ignore()); 
           Mapper.CreateMap<Publisher, Model.Publisher>().ForMember(x => x.Books, opt => opt.Ignore());
           Mapper.CreateMap<Author, Model.Author>().ForMember(x => x.Books, opt => opt.Ignore());

           var map = Mapper.CreateMap<Book, Model.Book>();
           map.ForMember(x => x.Author1, opt => opt.Ignore());
           map.ForMember(x => x.Publisher1, opt => opt.Ignore());
           map.ForMember(x => x.LoanItems, opt => opt.Ignore());
           map.ForMember(x => x.LiteratureItems, opt => opt.Ignore());

           Mapper.CreateMap<Model.UserInfo, UserInfo>();
           Mapper.CreateMap<Model.Publisher, Publisher>();
           Mapper.CreateMap<Model.Author, Author>();
           Mapper.CreateMap<Model.Book, Book>();

            Mapper.AssertConfigurationIsValid();
        }
    }
}
