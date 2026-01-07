using System;
using Event_Management_API.Data.Repositories;
using Event_Management_API.DTOS;
using Event_Management_API.Mappers;

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

    public async Task<EventDTO?> GetByIdAsync(int eventId)
    {
        var eventDb = await _eventRepository.GetByIdAsync(eventId);

        if (eventDb is null)
        {
            return null;
        }

        var eventDTO = _eventMapper.MapToDTO(eventDb);
        return eventDTO;
    }

    public async Task CreateAsync(EventCreationDTO eventCreationDTO)
    {
        var eventData = _eventMapper.MapToEntity(eventCreationDTO);

        await _eventRepository.CreateAsync(eventData);
    }
}
