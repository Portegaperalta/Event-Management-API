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
}
