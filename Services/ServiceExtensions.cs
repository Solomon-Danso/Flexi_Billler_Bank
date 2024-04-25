using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;

namespace Flexi_Biller_Back.Services
{
   public static class ServiceExtensions
    {
public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
         .AllowAnyOrigin() 
        .AllowAnyMethod()
        .AllowAnyHeader()
       
        
    );
});

public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(options =>
{
});





}
    
}