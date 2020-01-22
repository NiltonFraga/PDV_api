using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories.Salesman;
using Application.UseCase.Salesman.Add;
using Application.UseCase.Salesman.GetAll;
using Application.UseCase.Salesman.GetById;
using Application.UseCase.Salesman.Remove;
using Application.UseCase.Salesman.Update;
using AutoMapper;
using Infrastructure.Context;
using Infrastructure.Mapping;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace PDV_api
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
            services.AddScoped<IAddSalesmanUseCase, AddSalesmanUseCase>();
            services.AddScoped<IGetAllSalesmanUseCase, GetAllSalesmanUseCase>();
            services.AddScoped<IGetByIdSalesmanUseCase, GetByIdSalesmanUseCase>();
            services.AddScoped<IRemoveSalesmanUseCase, RemoveSalesmanUseCase>();
            services.AddScoped<IUpdateSalesmanUseCase, UpdateSalesmanUseCase>();
            services.AddScoped<ISalesmanReadOnlyUseCase, SalesmanRepository>();
            services.AddScoped<ISalesmanWriteOnlyUseCase, SalesmanRepository>();

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EntityToDomain());
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            ApplicationContext context = new ApplicationContext();
            context.Database.Migrate();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
