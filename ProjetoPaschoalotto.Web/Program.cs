using ProjetoPaschoalotto.Web.Data;
using Microsoft.EntityFrameworkCore;
using ProjetoPaschoalotto.Web.Services.Interface;
using ProjetoPaschoalotto.Web.Services;
using ProjetoPaschoalotto.Web.Respository.Interface;
using ProjetoPaschoalotto.Web.Respository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("PaschoalottoContextConnection") ?? throw new InvalidOperationException("Connection string 'PaschoalottoContextConnection' not found."); ;

builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));

builder.Services.AddMvc();

builder.Services.AddTransient<IUsuarioService, UsuarioService>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Relatorio}/{action=Index}/{id?}");

app.Run();
