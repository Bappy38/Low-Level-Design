using SplitWise.Data;
using SplitWise.Extensions;
using SplitWise.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory.CreateScope())
    {
        var repositoryContext = scope.ServiceProvider.GetService<RepositoryContext>();
        DataSeeder.SeedData<User>(repositoryContext).Wait();
    }
}

app.UseHttpsRedirection();

app.Run();
