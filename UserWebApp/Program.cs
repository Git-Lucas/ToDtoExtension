using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDtoExtension.Data;
using ToDtoExtension.DTOs;
using ToDtoExtension.Entities;
using UserWebApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserData, UserData>();

var app = builder.Build();

IServiceScope scope = app.Services.CreateScope();
DatabaseContext databaseContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
databaseContext.Database.Migrate();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/users", ([FromServices] IUserData userData, [FromBody] UserDto userDto) =>
{
    UserEntity userEntity = new(id: userDto.Id, username: userDto.Username, email: userDto.Email, password: "defaultPassword");
    userData.Create(userEntity);
    return userEntity.Id;
})
.WithName("PostUsers")
.WithOpenApi();

app.MapGet("/users", ([FromServices] IUserData userData) =>
{
    return userData.GetAll();
})
.WithName("GetUsers")
.WithOpenApi();

app.Run();
