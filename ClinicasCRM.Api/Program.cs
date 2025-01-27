using ClinicasCRM.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var conectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseNpgsql(conectionString));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
