using System;
using Event_Management_API.DTOS;
using Event_Management_API.Models;

namespace Event_Management_API.Services;

public interface IEventService
{
    Task<IEnumerable<EventDTO>> GetAllAsync();
    Task<EventDTO?> GetByIdAsync(int eventId);
    Task CreateAsync(EventCreationDTO eventCreationDto);
    Task UpdateAsync(EventUpdateDTO eventUpdateDto);
    Task<bool> DeleteAsync(int eventId);
}
