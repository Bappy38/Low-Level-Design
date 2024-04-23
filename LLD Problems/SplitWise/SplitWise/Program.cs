using SplitWise.Data;
using SplitWise.Extensions;
using SplitWise.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

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

app.MapControllers();

app.UseHttpsRedirection();

app.Run();
