using ServicioSOA.Modelo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

app.Run();

public class Program
{
    public static List<Producto> productos;

    public static void Main(string[] args)
    {
        productos = new List<Producto>();
        productos.Add(new Producto(1, "Queso", 3.10, 3));
        productos.Add(new Producto(2, "Yogurt", 2.50, 5));
        productos.Add(new Producto(3, "Mantequilla", 1.70, 2));
        productos.Add(new Producto(3, "Pan", 0.30, 10));
        CreateHostBuilder(args).Build().Run();

    }

}

