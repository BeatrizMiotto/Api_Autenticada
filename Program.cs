using ApiAutenticada.Models;
using ApiAutenticada.ModelViews;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

VeiculoRepositorio.Instancia().ListaVeiculo.Add(new Veiculos {Id = 1, Nome = "0001",Descricao = "Civic 1.0", Marca = "Honda", Modelo = "Civic", Ano = 2020 });
VeiculoRepositorio.Instancia().ListaVeiculo.Add(new Veiculos {Id = 2, Nome = "0002",Descricao = "Corolla Preto", Marca = "Toyota", Modelo = "Corolla", Ano = 2022 });

AdmRepositorio.Instancia().ListaAdm.Add(new Adm {Id = 1, Nome = "Jasmine",Email = "jas@gmail.com", User = "Jas001", Senha = "123456", Regra = "Adm" });
AdmRepositorio.Instancia().ListaAdm.Add(new Adm {Id = 2, Nome = "Eduardo",Email = "edu@gmail.com", User = "Dudu002", Senha = "789456", Regra = "Editor" });

app.Run();
