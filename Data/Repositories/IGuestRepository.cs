using System;
using Event_Management_API.Models;

namespace Event_Management_API.Data.Repositories;

public interface IGuestRepository
{
    Task<IEnumerable<Guest>> GetAllAsync();
    Task<Guest?> GetByIdAsync(int guestId);
    Task CreateAsync(Guest guestData);
    Task UpdateAsync(Guest guestData);
    Task DeleteAsync(Guest guestData);
}
