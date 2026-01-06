using System;
using Event_Management_API.Data;
using Event_Management_API.Models;

namespace Event_Management_API.Services;

public class EventService : IEventService
{
    private readonly ApplicationDbContext _context;

    public EventService(ApplicationDbContext context)
    {
        _context = context;
    }
}
