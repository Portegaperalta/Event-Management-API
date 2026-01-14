using System;
using Event_Management_API.DTOS;

namespace Event_Management_API.Services;

public interface IGuestService
{
    Task<IEnumerable<GuestDTO>> GetAllDTOAsync();
    Task<GuestDTO?> GetByIdDTOAsync(int guestId);
    Task CreateAsync(GuestCreationDTO guestCreationDTO);
    Task UpdateAsync(GuestUpdateDTO guestUpdateDTO);
    Task<bool> DeleteAsync(int guestId);
}
