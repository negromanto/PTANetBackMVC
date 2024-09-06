using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPI_MVC_ASR;
using WebAPI_MVC_ASR.Business;
using WebAPI_MVC_ASR.Datos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyección de dependencias para utilizar AutoMapper
builder.Services.AddAutoMapper(typeof(MappingConfig));

//Se pasa la cadena de conexión por inyección de dependencias
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultBD"));
});

builder.Services.AddScoped<IBusinessFeeds, BusinessFeeds>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
