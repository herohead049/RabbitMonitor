using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RabbitMonitor.Startup))]

namespace RabbitMonitor
{
    public partial class Startup
    {
        // cool 
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
