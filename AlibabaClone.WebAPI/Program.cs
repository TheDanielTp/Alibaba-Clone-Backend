using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AlibabaClone.Infrastructure;

var builder = WebApplication.CreateBuilder (args);

// Add the database context
builder.Services.AddDbContext<ApplicationDBContext> (options =>
    options.UseSqlServer (builder.Configuration.GetConnectionString ("DefaultConnection")));

builder.Services.AddScoped (typeof (IRepository<>), typeof (Repository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork> ();

var app = builder.Build ();
app.Run ();
