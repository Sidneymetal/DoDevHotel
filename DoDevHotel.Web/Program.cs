using Microsoft.EntityFrameworkCore;
using DoDevHotel.Lib.Context;
using DoDevHotel.Lib.Interfaces;
using DoDevHotel.Lib.Date.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DoDevHotelContext >(conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("DoDevHotelDB")).UseSnakeCaseNamingConvention());

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddScoped<IBaseRepositorio, BaseRepositorio>(); 
builder.Services.AddScoped<IEstadiaRepositorio, EstadiaRepositorio>(); 
builder.Services.AddScoped<IHospedeRepositorio, HospedeRepositorio>(); 
builder.Services.AddScoped<IHotelReposisorio, HotelRepositorio>(); 
builder.Services.AddScoped<IQuartoRepositorio, QuartoRepositorio>(); 
builder.Services.AddScoped<IServicoRepositorio, Servicopositorio>(); 
builder.Services.AddScoped<ITipoQuartoRepositorio, TipoQuartopositorio>(); 
builder.Services.AddScoped<IServicoXHotelRepositorio, ServicoXHotelRepositorio>(); 
builder.Services.AddScoped<IEstadiaXHospedeRepositorio, EstadiaXHospedeRepositorio>(); 

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
