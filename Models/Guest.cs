using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.Models;

public class Guest
{
    public int Id {get;set;}
    [Required]
    public required string FirstName {get;set;}
    [Required]
    public required string LastName{get;set;}
}
