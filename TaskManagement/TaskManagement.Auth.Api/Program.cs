using Microsoft.EntityFrameworkCore;
using TaskManagement.Auth.Business.Services;
using TaskManagement.Auth.Domain.Interfaces;
using TaskManagement.Auth.Infrastructure.Data;
using TaskManagement.Auth.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar los servicios
builder.Services.AddDbContext<AuthDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de la aplicación
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
