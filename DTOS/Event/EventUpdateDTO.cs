using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.DTOS;

public class EventUpdateDTO
{
    [Required(ErrorMessage = "Id is required")]
    public required int Id;
    [Required(ErrorMessage = "Name is required")]
    public required string Name {get;set;}
    [Required(ErrorMessage = "Description is required")]
    public required string Description {get;set;}
    [Required(ErrorMessage = "Location is required")]
    public required string Location {get;set;}
    public string? AccessCode {get;set;}
    [Required(ErrorMessage = "Start date is required")]
    public required DateTime StartDate {get;set;}
    [Required(ErrorMessage = "End date is required")]
    public required DateTime EndDate {get;set;}
    [Required(ErrorMessage = "Start time is required")]
    public required TimeSpan StartTime {get;set;}
    [Required(ErrorMessage = "End time is required")]
    public required TimeSpan EndTime{get;set;}
}
