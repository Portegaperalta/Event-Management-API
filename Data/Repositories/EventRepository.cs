using System;
using Event_Management_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_API.Data.Repositories;

public class EventRepository : IEventRepository
{
    private readonly ApplicationDbContext _context;

    public EventRepository(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
    }

    public async Task<IEnumerable<Event>> GetAllAsync()
    {
        return await _context.Events.ToListAsync();
    }

    public async Task<Event?> GetByIdAsync(int eventId)
    {
        return await _context.Events
                             .Where(e => e.Id == eventId)
                             .FirstOrDefaultAsync();
    }

    public async Task CreateAsync(Event eventData)
    {
        _context.Events.Add(eventData);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Event eventData)
    {
        _context.Events.Update(eventData);
        await _context.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(int eventId)
    {
        var deletedRecords = await _context.Events
                                           .Where(e => e.Id == eventId)
                                           .ExecuteDeleteAsync();
        return deletedRecords;
    }
}
