using System;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Contexts;
using AspNetCoreDatabaseLocalizationDemo.DataBase.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AspNetCoreDatabaseLocalizationDemo.Areas.Identity.IdentityHostingStartup))]
namespace AspNetCoreDatabaseLocalizationDemo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}