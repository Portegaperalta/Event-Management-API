using System;
using Event_Management_API.DTOS;
using Event_Management_API.Models;

namespace Event_Management_API.Mappers;

public class EventMapper
{
    public EventDTO MapToDTO(Event eventData)
    {
        return new EventDTO
        {
            Name = eventData.Name,
            Description = eventData.Description,
            Location = eventData.Location,
            StartDate = eventData.StartDate,
            EndDate = eventData.EndDate,
            StartTime = eventData.StartTime,
            EndTime = eventData.EndTime
        };
    }

    public Event MapToEntity(EventCreationDTO eventCreationDTO)
    {
        return new Event
        {
         Name = eventCreationDTO.Name,
         Description = eventCreationDTO.Description,
         Location = eventCreationDTO.Location,
         AccessCode = eventCreationDTO.AccessCode,
         StartDate = eventCreationDTO.StartDate,
         EndDate = eventCreationDTO.EndDate,
         StartTime = eventCreationDTO.StartTime,
         EndTime = eventCreationDTO.EndTime
        };
    }

    public Event MapToEntity(EventUpdateDTO eventUpdateDTO)
    {
        return new Event
        {
         Name = eventUpdateDTO.Name,
         Description = eventUpdateDTO.Description,
         Location = eventUpdateDTO.Location,
         AccessCode = eventUpdateDTO.AccessCode,
         StartDate = eventUpdateDTO.StartDate,
         EndDate = eventUpdateDTO.EndDate,
         StartTime = eventUpdateDTO.StartTime,
         EndTime = eventUpdateDTO.EndTime
        };
    }
}
