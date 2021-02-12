using JobTrackingProject.Business.Abstract;
using JobTrackingProject.Business.Concrete;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore;
using JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JobTrackingProject.MvcWebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDutyService, DutyManager>();
            services.AddScoped<IDutyDal, EfDutyDal>();

            services.AddScoped<IUrgencyService, UrgencyManager>();
            services.AddScoped<IUrgencyDal, EfUrgencyDal>();

            services.AddScoped<IReportService, ReportManager>();
            services.AddScoped<IReportDal, EfReportDal>();

            services.AddDbContext<TodoContext>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TodoContext>();

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"areas",
                    pattern:"{area}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}