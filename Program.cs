using Microsoft.EntityFrameworkCore;
using InventarioFarmaciaAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. Configuración de la conexión a la base de datos
// Asegúrate de que el nombre de conexión en appsettings.json sea 'DefaultConnection'
builder.Services.AddDbContext<FarmaciaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Servicios básicos
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. Configuración del entorno
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// 4. Mapeo de controladores
app.MapControllers();

app.Run();