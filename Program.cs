using Event_Management_API.Data;
using Event_Management_API.Data.Repositories;
using Event_Management_API.Mappers;
using Event_Management_API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Services Area 

builder.Services.AddScoped<EventMapper>();
builder.Services.AddScoped<IEventService,EventService>();
builder.Services.AddScoped<IEventRepository,EventRepository>();
builder.Services.AddScoped<IGuestService,GuestService>();
builder.Services.AddScoped<IGuestRepository,GuestRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

//Middlewares Area
var app = builder.Build();

app.MapControllers();

app.Run();
