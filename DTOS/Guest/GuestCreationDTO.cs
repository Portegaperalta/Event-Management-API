using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.DTOS;

public class GuestCreationDTO
{
    [Required(ErrorMessage = "The field {0} is required")]
    public required string FirstName {get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    public required string LastName{get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    [Phone]
    public required string PhoneNumber {get;set;}
}
