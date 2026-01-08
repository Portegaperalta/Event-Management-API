using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.DTOS;

public class EventCreationDTO
{
    [Required(ErrorMessage = "The field {0} is required")]
    public required string Name {get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    public required string Description {get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    public required string Location {get;set;}
    public string? AccessCode {get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    public required DateTime StartDate {get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    public required DateTime EndDate {get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    public required TimeSpan StartTime {get;set;}
    [Required(ErrorMessage = "The field {0} is required")]
    public required TimeSpan EndTime{get;set;}
}
