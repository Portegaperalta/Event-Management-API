using Event_Management_API.Data;
using Event_Management_API.Mappers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Services Area 

builder.Services.AddScoped<EventMapper>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

//Middlewares Area
var app = builder.Build();

app.MapControllers();

app.Run();
