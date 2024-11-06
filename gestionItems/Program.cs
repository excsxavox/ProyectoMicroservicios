
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using gestionItems.service;
using gestionItems.Commands;
using Microsoft.AspNetCore.Builder; // Asegúrate de que este namespace sea correcto

var builder = WebApplication.CreateBuilder(args);

// Configura los servicios
builder.Services.AddControllers(); // Agrega esta línea para registrar los controladores
// Asegúrate de tener el connection string configurado

builder.Services.AddMediatR(typeof(CreateItemCommand)); // Asegúrate de que MediatR esté configurado

var app = builder.Build();

// Configura el middleware y las rutas
app.UseRouting();
app.MapControllers(); // Si usas controladores

app.Run();