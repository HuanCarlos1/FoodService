using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Hangfire.MemoryStorage;
using Kamall_foods_server_aspNetCore.Data.CacheSystem;
using Kamall_foods_server_aspNetCore.Data.Context;
using Kamall_foods_server_aspNetCore.Data.Jobs;
using Kamall_foods_server_aspNetCore.Repository;
using Kamall_foods_server_aspNetCore.Repository.IRepository;
using Kamall_foods_server_aspNetCore.Services;
using Kamall_foods_server_aspNetCore.Services.Email;
using Kamall_foods_server_aspNetCore.Services.IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace Kamall_foods_server_aspNetCore;

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
        services.AddMemoryCache();

        services.AddControllers();
        services.AddControllers().AddNewtonsoftJson();
        //services.AddMvc().AddControllersAsServices();

        services.Configure<MailTypes>(Configuration.GetSection("MailSettings"));

        services.AddHttpContextAccessor();

        services.AddDbContext<DatabaseContext>(options =>
            options.UseMySQL(Environment.GetEnvironmentVariable("DATASOURCE")));

        services.AddHangfire(config =>
            config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseDefaultTypeSerializer()
                .UseMemoryStorage());

        services.AddHangfireServer();

        services.AddTransient<IPersonRepository, PersonRepository>();
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IRestaurantAdminRepository, RestaurantAdminRepository>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IPersonService, PersonService>();
        services.AddScoped<IRestaurantAdminService, RestaurantAdminService>();
        services.AddScoped<IJobs, Jobs>();
        services.AddSingleton<ICacheSystem, CacheSystem>();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "KamallFoodsServer", Version = "v1" });
        });

        services.AddHttpsRedirection(options =>
        {
            options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
            options.HttpsPort = 5001;
        });

        services.ConfigureApplicationCookie(options => options.LoginPath = "/login");

        services.AddMvc();

        services.AddAuthentication(o =>
        {
            o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            o.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(jwtBearerOptions =>
        {
            jwtBearerOptions.SaveToken = true;
            jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey =
                    new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWTSECRET") ?? string.Empty)),
                RequireSignedTokens = true,
                RequireExpirationTime = true,
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.FromMinutes(5)
            };

            jwtBearerOptions.Events = new JwtBearerEvents
            {
                OnMessageReceived = context =>
                {
                    if (context.Request.Cookies.ContainsKey("X-Access-Token"))
                        context.Token = context.Request.Cookies["X-Access-Token"];

                    return Task.CompletedTask;
                },
                OnAuthenticationFailed = ctx =>
                {
                    if (ctx.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        ctx.Response.Headers.Add("Token-Expired", "true");
                    return Task.CompletedTask;
                }
            };
        }).AddCookie(options =>
        {
            options.LoginPath = "/login";
            options.LogoutPath = "/logout";
        });

        services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.KnownProxies.Add(IPAddress.Parse("3.217.196.56"));
            options.ForwardedHeaders =
                ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;

            options.KnownNetworks.Clear();
            options.KnownProxies.Clear();
        });

        services.AddCors(options =>
        {
            options.AddPolicy("CorsApi",
                builder => builder.WithOrigins("http://localhost:3000", "https://kamall-foods.com",
                        "https://www.kamall-foods.com", "https://kamall-foods-panel.com",
                        "https://www.kamall-foods-panel.com, https://feature.d8qtesa7y5ir9.amplifyapp.com")
                    .AllowAnyHeader().AllowCredentials().SetIsOriginAllowed(_ => true)
                    .WithMethods("GET", "PUT", "POST", "DELETE"));
        });

        services.Configure<CookiePolicyOptions>(options =>
        {
            options.CheckConsentNeeded = context => true;
            options.MinimumSameSitePolicy = SameSiteMode.None;
            options.HttpOnly = HttpOnlyPolicy.Always;
            options.Secure = CookieSecurePolicy.Always;
            // you can add more options here and they will be applied to all cookies (middleware and manually created cookies)
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
        IRecurringJobManager recurringJobManager, IServiceProvider serviceProvider)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(
                c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Kamall_foods_server_aspNetCore v1"));
        }

        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
        });

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseCors("CorsApi");

        //Order is important !
        app.UseAuthentication();
        app.UseAuthorization();
        
        app.Use(async (ctx, next) =>
        {
            // using Microsoft.AspNetCore.Http;
            var endpoint = ctx.GetEndpoint();

            if (endpoint != null)
            {
               
            }

            await next();
        });

        app.UseEndpoints(endpoints =>{ endpoints.MapControllers(); });
        app.UseDeveloperExceptionPage();
        
        recurringJobManager.AddOrUpdate("DeleteUnverifiedUsers",
            () => serviceProvider.GetService<IJobs>().DeleteUnverifiedUsers(), Cron.Weekly);
    }
}