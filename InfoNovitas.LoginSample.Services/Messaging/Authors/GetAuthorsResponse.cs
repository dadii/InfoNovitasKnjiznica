﻿using InfoNovitas.LoginSample.Services.Messaging.Views.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services.Messaging.Authors
{
    public class GetAuthorsResponse:LibraryResponseBase
    {
        public List<Author> Authors { get; set; }
    }
}
