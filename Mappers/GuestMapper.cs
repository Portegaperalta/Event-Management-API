using System;
using Event_Management_API.DTOS;
using Event_Management_API.Models;

namespace Event_Management_API.Mappers;

public class GuestMapper
{
    public GuestDTO MapToDTO(Guest guest)
    {
        return new GuestDTO
        {
            Id = guest.Id,
            FirstName = guest.FirstName,
            LastName = guest.LastName
        };
    }

    public Guest MapToEntity(GuestCreationDTO guestCreationDTO)
    {
        return new Guest
        {
          FirstName = guestCreationDTO.FirstName,
          LastName = guestCreationDTO.LastName,
          PhoneNumber = guestCreationDTO.PhoneNumber  
        };
    }

    public Guest MapToEntity(GuestUpdateDTO guestUpdateDTO)
    {
        return new Guest
        {
          Id = guestUpdateDTO.Id,
          FirstName = guestUpdateDTO.FirstName,
          LastName = guestUpdateDTO.LastName,
          PhoneNumber = guestUpdateDTO.PhoneNumber
        };
    }
}
