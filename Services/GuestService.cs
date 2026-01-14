using System;
using System.Security.Cryptography.X509Certificates;
using Event_Management_API.Data.Repositories;
using Event_Management_API.DTOS;
using Event_Management_API.Mappers;

namespace Event_Management_API.Services;

public class GuestService : IGuestService
{
    private readonly IGuestRepository _guestRepository;
    private readonly GuestMapper _guestMapper;

    public GuestService(IGuestRepository guestRepository,GuestMapper guestMapper)
    {
        _guestRepository = guestRepository;
        _guestMapper = guestMapper;
    }

    public async Task<IEnumerable<GuestDTO>> GetAllDTOAsync()
    {
        var guestsDB = await _guestRepository.GetAllAsync();
        var guestsDTOS = guestsDB.Select(guestDb => _guestMapper.MapToDTO(guestDb));

        return guestsDTOS;
    }

    public async Task<GuestDTO?> GetByIdDTOAsync(int guestId)
    {
        var guestDb = await _guestRepository.GetByIdAsync(guestId);
        
        if (guestDb is null)
        {
            return null;
        }
        
        var guestDTO = _guestMapper.MapToDTO(guestDb);
        return guestDTO;
    }

    public async Task CreateAsync(GuestCreationDTO guestCreationDTO)
    {
        var guestData = _guestMapper.MapToEntity(guestCreationDTO);
        await _guestRepository.CreateAsync(guestData);
    }

    public async Task UpdateAsync(GuestUpdateDTO guestUpdateDTO)
    {
        var guestUpdateData = _guestMapper.MapToEntity(guestUpdateDTO);
        await _guestRepository.UpdateAsync(guestUpdateData);
    }

    public async Task<bool> DeleteAsync(int guestId)
    {
        var guestDb = await _guestRepository.GetByIdAsync(guestId);

        if (guestDb is null)
        {
            return false;
        }

        await _guestRepository.DeleteAsync(guestDb);
        return true;
    }
}

public interface IGuestService
{
}