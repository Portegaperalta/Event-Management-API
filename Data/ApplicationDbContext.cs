using System;
using Event_Management_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base (options)
    {
    }
}
