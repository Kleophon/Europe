
using Scalar.AspNetCore;

namespace Europe.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);
            
            builder.AddServiceDefaults();


            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            var app = builder.Build();

            app.MapDefaultEndpoints();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference("/docs",options =>
                {
                    options.WithTitle("Europe API Docs")
                           .WithTheme(ScalarTheme.DeepSpace) 
                           .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient).WithDocumentDownloadType(DocumentDownloadType.Both);
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();



            app.MapGet("/", () => "Europe.Server is running...");

            app.Run();
        }
    }
}
