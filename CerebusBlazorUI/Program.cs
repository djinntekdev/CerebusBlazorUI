using CerebusBlazorUI.Components;
using CerebusBlazorUI.Utilities.Entity;
using CerebusBlazorUI.Utilities.Session;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMemoryCache();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddFluentUIComponents();
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie();
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(options =>
//    {
//        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
//        options.SlidingExpiration = true;
//        options.AccessDeniedPath = "/Forbidden/";
//        options.LoginPath = "/login";
//    });

//builder.Services.AddAuthentication("Bearer")
//    .AddJwtBearer("Bearer", options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateIssuer = true,
//            ValidateAudience = true,
//            ValidateLifetime = true,
//            ValidateIssuerSigningKey = true,
//            ValidIssuer = "MyAuthServer",
//            ValidAudience = "MyApi",
//            IssuerSigningKey = new SymmetricSecurityKey(
//                Encoding.UTF8.GetBytes("SUPER_SECRET_KEY_123"))
//        };
//    });
//builder.Services.AddAuthorization();

//builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<CerebusContext>(options =>
    options.UseMySQL("Server=localhost; User ID=bobreed; Password=!#AdminPwd10; Database=cerebus"));
//builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();

//builder.Services.AddSingleton<ApplicationAccessTokenManager>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
//app.UseAuthentication();
//app.UseAuthorization();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
//app.MapRazorComponents<App>();

app.Run();
