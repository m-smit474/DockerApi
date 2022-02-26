using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace TicTacToe;

public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
    }

    public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IWebHostEnvironment environment) 
    {
        app.UseMvc();
    }
}
