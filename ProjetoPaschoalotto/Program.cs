using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ProjetoPaschoalotto.Data;
using ProjetoPaschoalotto.Respository;
using ProjetoPaschoalotto.Respository.Interface;
using ProjetoPaschoalotto.Services;
using ProjetoPaschoalotto.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PaschoalottoContextConnection") ?? throw new InvalidOperationException("Connection string 'PaschoalottoContextConnection' not found."); ;

builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
// Add services to the container.


builder.Services.AddMvc();

builder.Services.AddTransient<IUsuarioService, UsuarioService>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
