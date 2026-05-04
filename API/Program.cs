using AeroMexic.Infrasctructure.Data;
using API.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI para MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(AeroMexic.Application.AssemblyReference).Assembly);
    cfg.AddOpenBehavior(typeof(AeroMexic.Application.Behaviors.ValidationBehavior<,>));
    cfg.AddOpenBehavior(typeof(AeroMexic.Application.Behaviors.LoggingBehavior<,>));
    cfg.AddOpenBehavior(typeof(AeroMexic.Application.Behaviors.TransactionBehavior<,>));
    cfg.AddOpenBehavior(typeof(AeroMexic.Application.Behaviors.ExceptionBehavior<,>));
});

builder.Services.AddDbContext<AeronauticaNacionalDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
