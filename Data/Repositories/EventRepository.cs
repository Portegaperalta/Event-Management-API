using System;
using Event_Management_API.Models;

namespace Event_Management_API.Data.Repositories;

public class EventRepository : IEventRepository
{
    private readonly ApplicationDbContext _context;

    public EventRepository(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
    }
}
