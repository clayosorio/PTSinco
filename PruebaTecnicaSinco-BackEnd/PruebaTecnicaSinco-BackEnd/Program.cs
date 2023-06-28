using PruebaTecnicaSinco_BackEnd.Context;
using PruebaTecnicaSinco_BackEnd.Controllers;
using PruebaTecnicaSinco_BackEnd.Repositories.IRepositories;
using PruebaTecnicaSinco_BackEnd.Services;
using PruebaTecnicaSinco_BackEnd.Services.IServices;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<PTContext>(builder.Configuration.GetConnectionString("DBPruebaSinco"));

//Services
builder.Services.AddScoped<IAlumnosServices, AlumnosServices>();
builder.Services.AddScoped<IAsignaturasServices, AsignaturasServices>();
builder.Services.AddScoped<IProfesoresServices, ProfesoresServices>();

//Repositories
builder.Services.AddScoped<IAlumnosRepositories, AlumnosRepositories>();
builder.Services.AddScoped<IAsignaturasRepositories, AsignaturasRepositories>();
builder.Services.AddScoped<IProfesoresRepositories, ProfesoresRepositories>();


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
