
using RestEase;
using Tamagotchi.Facades;
using Tamagotchi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton(sp => RestClient.For<ITamagotchiService>("https://pokeapi.co/api/v2/"));

builder.Services.AddTransient<ITamagotchiFacade, TamagotchiFacade>();

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

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();

