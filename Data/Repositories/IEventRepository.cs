using System;
using Event_Management_API.Models;

namespace Event_Management_API.Data.Repositories;

public interface IEventRepository
{
    Task <IEnumerable<Event>> GetEventsAsync();
    Task <Event?> GetEventAsync(int eventId);
    Task CreateEventAsync(Event eventData);
    Task UpdateEventAsync(Event eventData);
    Task<int> DeleteEventAsync(int eventId);
}
