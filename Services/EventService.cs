using System;
using Event_Management_API.Data;
using Event_Management_API.Data.Repositories;
using Event_Management_API.DTOS;
using Event_Management_API.Mappers;
using Event_Management_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_API.Services;

public class EventService : IEventService
{
    private readonly EventRepository _eventRepository;
    private readonly EventMapper _eventMapper;
    public EventService(EventRepository eventRepository,EventMapper eventMapper)
    {
        _eventRepository = eventRepository;
        _eventMapper = eventMapper;
    }

        public async Task<IEnumerable<EventDTO>> GetAllAsync()
    {
        var eventsDb = await _eventRepository.GetAllAsync();
        var eventsDTOs =eventsDb.Select(eventDb => _eventMapper.MapToDTO(eventDb));

        return eventsDTOs;
    }
}
