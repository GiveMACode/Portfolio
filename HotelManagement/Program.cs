using Microsoft.EntityFrameworkCore;
using HotelManagement.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>(
    options => options.UseSqlite("Data Source=hotelmanagement.db;Cache=shared")
);

builder.Services.AddControllers();
// Add services to the container.
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

app.UseCors(
    cors => cors.AllowAnyOrigin().
        AllowAnyMethod().
        AllowAnyHeader()
);


app.UseAuthorization();

app.MapControllers();

app.Run();