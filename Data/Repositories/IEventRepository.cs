using System;
using Event_Management_API.Models;

namespace Event_Management_API.Data.Repositories;

public interface IEventRepository
{
    Task <IEnumerable<Event>> GetAllAsync();
    Task <Event?> GetByIdAsync(int eventId);
    Task CreateAsync(Event eventData);
    Task UpdateAsync(Event eventData);
    Task<int> DeleteAsync(int eventId);
}
