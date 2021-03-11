using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;

namespace CustomerAgenda.Api.Configurations
{
    public static class SwaggerConfig
    {
        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Customer Agenda",
                        Version = "v1",
                        Description = "Asp.Net Core WebAPI developed to manage customer contacts.",
                        Contact = new OpenApiContact
                        {
                            Name = "Rafael Brugiolo Souza",
                            Url = new Uri("https://www.linkedin.com/in/rafael-brugiolo/")
                        }
                    });

                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CustomerAgenda");
            });

            return app;
        }
    }
}
