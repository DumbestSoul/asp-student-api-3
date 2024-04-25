using Microsoft.EntityFrameworkCore;
using Student.Business.Contract;
using Student.Business.Business;
using Student.Entity.Models;
using Student.Repository.Contracts;
using Student.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependecies Injection
builder.Services.AddScoped<DbContext, StudentDbContext>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentBusiness, StudentBusiness>();

//Connection Injection
builder.Services.AddDbContext<StudentDbContext>(
	options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
	);

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
