using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SampleApp.Data;

namespace SampleApp.DI
{
    public class Boostrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            //entity framework
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
        }
    }
}
