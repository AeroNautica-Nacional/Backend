using AeroMexic.Infrasctructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cgf =>
{
    cfg.RegisterServicesFromAssembly(typeof(AeroMexic.Application.AssemblyReference).Assembly);
    cfg.AddOpenBehavior(typeof(AeroMexic.Application.Behaviors.ValidationBehavior<,>));
    cfg.AddOpenBehavior(typeof(AeroMexic.Application.Behaviors.LoggingBehavior<,>));

});

builder.Services.AddDbContext<AeronauticaNacionalDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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
