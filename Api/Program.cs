using Api.Interfaces;
using Api.Services;
using Microsoft.OpenApi;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSwaggerGen();
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddTransient<IOperationService, OperationServices>();
             //builder.Services.AddScoped<IOperationService, OperationServices>();
             //builder.Services.AddSingleton<IOperationService, OperationServices>();

            builder.Services.AddControllers();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger(options =>
                {
                    options.OpenApiVersion = OpenApiSpecVersion.OpenApi3_1;
                });
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.

            //app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
