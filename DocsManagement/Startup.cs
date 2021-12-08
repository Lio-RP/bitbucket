<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using DocsManagement.Models;
using Microsoft.EntityFrameworkCore;
=======
﻿using Microsoft.Owin;
using Owin;
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)

[assembly: OwinStartupAttribute(typeof(DocsManagement.Startup))]
namespace DocsManagement
{
    public partial class Startup
    {
<<<<<<< HEAD
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                Configuration["Data:DocsManagementDocuments:ConnectionString"]));
            services.AddTransient<IServiceDocsRepository, EFServicesDocsRepository>();
            services.AddTransient<IAgreementDocsRepository, EFAgreementDocsRepository>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ServiceDocs}/{action=List}/{RegistrationNomer?}");

            });
=======
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
>>>>>>> 2cb8d9d (Добовлен Controllers, Views и подклучин к БД)
        }
    }
}
