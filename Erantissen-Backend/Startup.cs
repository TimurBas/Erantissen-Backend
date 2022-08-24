using Erantissen_Backend.App.Services;
using Erantissen_Backend.App.Services.Interfaces;
using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Data.Repositories;
using Erantissen_Backend.Domain.Repositories;
using Erantissen_Backend.Query.Queries;
using Erantissen_Backend.Query.Queries.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Erantissen_Backend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Erantissen_Backend", Version = "v1" });
            });
            services.AddDbContext<Context>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductQuery, ProductQuery>();
            services.AddScoped<IHeroRepository, HeroRepository>();
            services.AddScoped<IHeroService, HeroService>();
            services.AddScoped<IHeroQuery, HeroQuery>();
            services.AddScoped<IMostBoughtProductRepository, MostBoughtProductRepository>();
            services.AddScoped<IMostBoughtProductService, MostBoughtProductService>();
            services.AddScoped<IMostBoughtProductQuery, MostBoughtProductQuery>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryQuery, CategoryQuery>();
            services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();
            services.AddScoped<ISubcategoryService, SubcategoryService>();
            services.AddScoped<ISubcategoryQuery, SubcategoryQuery>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Erantissen_Backend v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}