using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoNovitas.LoginSample.Web.Api.Models.Books
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Author { get; set; }
        public int Publisher { get; set; }
        public int Available { get; set; }
        public string Isbn { get; set; }
        public string Godina { get; set; }
    }
}