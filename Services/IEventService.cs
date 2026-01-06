using System;
using Event_Management_API.Models;

namespace Event_Management_API.Services;

public interface IEventService
{
    Task<IEnumerable<Event>> GetAllAsync();
    Task<Event> GetByIdAsync(int eventId);
    Task CreateAsync(Event eventData);
    Task UpdateAsync(Event enventUpdateData);
    Task DeleteAsync(int eventId);
}
