using CQRS_with_MediaTR.Behaviors;
using CQRS_with_MediaTR.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Adding MediaTR Config
builder.Services.AddMediatR(config =>
config.RegisterServicesFromAssembly(typeof(Program).Assembly));

// Register DataStore Service
builder.Services.AddSingleton<FakeDataStore>();
builder.Services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

// Add services to the container.

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
