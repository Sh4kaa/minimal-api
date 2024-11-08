using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Interfaces;
using minimal_api.Dominio.ModelsViews;
using minimal_api.Infraestrutura.Db;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbContexto>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("sqlserver"));
});
var app = builder.Build();


app.MapGet("/", () => Results.Json(new Home()));
app.MapPost("/login", ([FromBody] LoginDTO loginDTO, IAdministradorServico administradorServico) =>
{
  if (administradorServico.Login(loginDTO) != null)
    return Results.Ok("Login com sucesso");
  else
    return Results.Unauthorized();
});

app.UseSwagger();
app.UseSwaggerUI();
app.Run();
