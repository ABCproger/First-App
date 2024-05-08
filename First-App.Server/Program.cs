using First_App.Server.DataAccess.Data;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataAccess.Repositories;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.Extensions;
using First_App.Server.Middleware;
using First_App.Server.Observers;
using First_App.Server.Observers.Interfaces;
using First_App.Server.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddControllers()
    .AddFluentValidation(x =>
    {
        x.ImplicitlyValidateChildProperties = true;
        x.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<ICardColumnRepository, CardColumnRepository>();
builder.Services.AddScoped<ICardActivityLogsRepository, CardActivityLogsRepository>();
builder.Services.AddScoped<ICardActivity,CardActivity>();
builder.Services.AddScoped<ICreateCardObserver, CreateCardObserver>();
builder.Services.AddScoped<IEditCardObserver, EditCardObserver>();
builder.Services.AddScoped<IDeleteCardObserver,DeleteCardObserver>();
builder.Services.AddScoped<IMoveCardObserver, MoveCardObserver>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<GlobalErrorHandlingMiddleware>();

app.MapControllers();

app.Run();
