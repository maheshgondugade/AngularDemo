﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular_MVC.Startup))]
namespace Angular_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
