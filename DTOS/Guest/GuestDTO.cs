using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.DTOS;

public class GuestDTO
{
    public int Id {get;set;}
    [Required]
    public required string FirstName {get;set;}
    [Required]
    public required string LastName{get;set;}
}
