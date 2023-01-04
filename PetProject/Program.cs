using Microsoft.EntityFrameworkCore;
using PetProject.Models;
using PetProject.Model.Model;
using System;
using PetProject.Interfaces.Interfaces;
using PetProject.Repository;
using PetProject.Interfaces.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager Configuration = builder.Configuration;
builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IListTeacher<ListTeacher>, ListTeacherRepository>();
builder.Services.AddTransient<ListTeacherService, ListTeacherService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(option => {
    option.UseSqlServer(Configuration.GetConnectionString("MyDb"));
});

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
