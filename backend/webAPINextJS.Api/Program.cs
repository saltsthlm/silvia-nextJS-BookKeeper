using webAPINextJS.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IBookKeeper, BookKeeper>();
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

app.UseCors(policy =>
{
    policy.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader(); 
});

app.UseAuthorization();

app.MapControllers();

var port = Environment.GetEnvironmentVariable("PORT") ?? "5065"; // CHANGE THE “8080" TO THE PORT YOUR BACKEND RUNS ON!
var url = $"http://0.0.0.0:{port}";

app.Run();
