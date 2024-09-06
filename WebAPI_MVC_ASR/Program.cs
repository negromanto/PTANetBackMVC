using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPI_MVC_ASR;
using WebAPI_MVC_ASR.Business;
using WebAPI_MVC_ASR.Datos;
using WebAPI_MVC_ASR.Repository;
using WebAPI_MVC_ASR.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyección de dependencias para utilizar AutoMapper
builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<IBusinessFeeds, BusinessFeeds>();
builder.Services.AddScoped<IFeedRepository, FeedRepository>();

//Se pasa la cadena de conexión por inyección de dependencias
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    string? connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") ?? builder.Configuration.GetConnectionString("DefaultBD");
    option.UseSqlServer(connectionString);
});



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


