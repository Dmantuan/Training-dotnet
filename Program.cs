global using dotnet.models;
global using dotnet.Services.CharacterService;
global using dotnet.Dtos.Character;
global using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/* 
    Now the web api know that is has to use the character service class whenever a controller wants
        inject the ICharacterService
    
    With addScoped we create a new instance of the request service for every request that comes in
    With addTransient provides a new instance to every controller and to every service, 
        even within the same request
    With addSingleton creates only one instance that is used for every request
*/
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
