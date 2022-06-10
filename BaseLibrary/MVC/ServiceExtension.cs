using BaseLibrary.EntityFramework;
using BaseLibrary.EntityFramework.IRepository;
using BaseLibrary.EntityFramework.Repository;
using BaseLibrary.Extensions;
using BaseLibrary.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BaseLibrary.MVC
{
    public static class ServiceExtension
    {
        public static IServiceCollection AdditionalServices(this IServiceCollection services, ConfigurationManager configuration, MasterStaticController.Mode mode)
        {
            

            //services.AddScoped<IConverterRepository, ConverterRepository>();
            

            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            //services.AddScoped<IDatabaseTransaction, DatabaseTransaction>();

            services.AddEndpointsApiExplorer();

            

            //services.AddAuthentication(opt =>
            //{
            //    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(options =>
            //{
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,

            //        ValidIssuer = configuration["Tokens:Issuer"],
            //        ValidAudience = configuration["Tokens:Audience"],
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Tokens:Key"]))
            //    };
            //})
            //    ;

            #region enable cors
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyHeader()
                    .AllowAnyMethod()
                    .WithOrigins(configuration["Cors:Origin"])
                    .AllowCredentials();
                });
            });
            #endregion

            services.AddTransient<ITokenService, TokenServices>();

            services.AddAntiforgery(options =>
            {
                options.HeaderName = "X-XSRF-TOKEN";
                
            });

         

            services.AddRazorPages();

            if (mode != MasterStaticController.Mode.Normal)
            {
                services.AddSingleton<IPolicyEvaluator, FakePolicyEvaluator>();
            }

            return services;
        }
    }
}
