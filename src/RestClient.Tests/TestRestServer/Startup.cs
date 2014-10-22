﻿using System.Net.Http.Formatting;
using System.Web.Http;
using Owin;

namespace Rest.Tests.TestRestServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();
            var defaultNegotiator = new DefaultContentNegotiator(excludeMatchOnTypeOnly: true);
            httpConfiguration.Services.Replace(typeof(IContentNegotiator), defaultNegotiator);
            httpConfiguration.MapHttpAttributeRoutes();
            app.UseWebApi(httpConfiguration);
        }
    }
}