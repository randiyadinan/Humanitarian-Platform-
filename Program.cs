using Microsoft.EntityFrameworkCore;
using HumanitarianAPI.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("HumanitarianDb"));

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();

app.Run();
