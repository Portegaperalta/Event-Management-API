using System;
using Event_Management_API.Data;
using Event_Management_API.DTOS;
using Event_Management_API.Mappers;
using Event_Management_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_API.Services;

public class EventService : IEventService
{
    private readonly ApplicationDbContext _context;
    private readonly EventMapper _eventMapper;
    public EventService(ApplicationDbContext context,EventMapper eventMapper)
    {
        _context = context;
        _eventMapper = eventMapper;
    }

        public async Task<IEnumerable<EventDTO>> GetAllAsync()
    {
        var eventsDb = await _context.Events.ToListAsync();
        var eventsDTOs =eventsDb.Select(eventDb => _eventMapper.MapToDTO(eventDb));

        return eventsDTOs;
    }
}
