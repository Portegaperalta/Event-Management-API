using System;
using Event_Management_API.Data.Repositories;
using Event_Management_API.DTOS;
using Event_Management_API.Mappers;

namespace Event_Management_API.Services;

public class EventService : IEventService
{
    private readonly IEventRepository _eventRepository;
    private readonly EventMapper _eventMapper;
    public EventService(IEventRepository eventRepository,EventMapper eventMapper)
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

    public async Task UpdateAsync(EventUpdateDTO eventUpdateDTO)
    {
        var eventUpdateData = _eventMapper.MapToEntity(eventUpdateDTO);

        await _eventRepository.UpdateAsync(eventUpdateData);
    }

    public async Task<bool> DeleteAsync(int eventId)
    {
        var eventData = await _eventRepository.GetByIdAsync(eventId);

        if (eventData is null)
        {
            return false;
        }

        await _eventRepository.DeleteAsync(eventData);
        return true;
    }
}
