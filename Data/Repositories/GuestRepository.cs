using System;
using Event_Management_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_API.Data.Repositories;

public class GuestRepository : IGuestRepository
{
    private readonly ApplicationDbContext _context;

    public GuestRepository (ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
    }

    public async Task<IEnumerable<Guest>> GetAllAsync()
    {
        return await _context.Guests.ToListAsync();
    }

    public async Task<Guest?> GetByIdAsync(int guestId)
    {
        return await _context.Guests.Where(g => g.Id == guestId)
                                    .FirstOrDefaultAsync();
    }

    public async Task CreateAsync(Guest guestData)
    {
        _context.Guests.Add(guestData);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Guest guestData)
    {
        _context.Guests.Update(guestData);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guest guestData)
    {
        _context.Guests.Remove(guestData);
        await _context.SaveChangesAsync();
    }
}
