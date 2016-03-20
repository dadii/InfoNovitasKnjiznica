﻿using Autofac;
using InfoNovitas.LoginSample.Repositories;
using InfoNovitas.LoginSample.Repositories.Publishers;
using InfoNovitas.LoginSample.Repositories.Users;
using InfoNovitas.LoginSample.Repositories.Authors;
using InfoNovitas.LoginSample.Repositories.Books;
using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Services.Impl;

namespace InfoNovitas.LoginSample.Web.Api
{
    public class LoginSampleModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<PublisherRepository>().As<IPublisherRepository>();
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>();
            builder.RegisterType<BookRepository>().As<IBookRepository>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<PublisherService>().As<IPublisherService>();
            builder.RegisterType<AuthorService>().As<IAuthorService>();
            builder.RegisterType<BookService>().As<IBookService>();
        }
    }
}