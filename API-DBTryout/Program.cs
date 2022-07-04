using API_DBTryout.Data;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API_DBTryout
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.
            var ERconnectionString = builder.Configuration.GetConnectionString("ERDefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            var LGconnectionString = builder.Configuration.GetConnectionString("LGDefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ERDbContext>(options =>
                options.UseSqlServer(ERconnectionString));
            builder.Services.AddDbContext<LGDbContext>(options =>
                options.UseSqlServer(LGconnectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ERDbContext>();
            builder.Services.AddRazorPages();
            builder.Services.AddHttpClient<MyClient>();
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                //builder.RegisterGeneric(typeof(LGGenericRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
                builder.RegisterGeneric((context, types, parameters) =>
                {
                    return Activator.CreateInstance(typeof(LGGenericRepository<>).MakeGenericType(types));
                }
                    ).As(typeof(IRepository<>));
            });

            //builder.Services.AddScoped(typeof(IRepository<>)(provider =>
            //{
            //    var httpContextService = provider.GetService<IHttpContextAccessor>();
            //    if (httpContextService.HttpContext.Request.Path.Value == "/LG")
            //    {
            //        return typeof(LGGenericRepository<>);

            //    }
            //    else
            //    {
            //        //return new ErDataHandler(provider.GetService<ERDbContext>(), new MyClient(new HttpClient()));
            //        return typeof(LGGenericRepository<>);
            //    }
            //});

            //builder.Services.AddScoped(typeof(IRepository<>), typeof(LGGenericRepository<>));
            //builder.Services.AddScoped<IRepository<Shul>, ERShulRepository>();
            //builder.Services.AddScoped<IRepository<Shop>, ERShopRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.7
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}