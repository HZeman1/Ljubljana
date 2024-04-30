using Microsoft.EntityFrameworkCore;
using REST;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<LjubljanaDeloContext>(options =>options.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;"));
var app = builder.Build();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
