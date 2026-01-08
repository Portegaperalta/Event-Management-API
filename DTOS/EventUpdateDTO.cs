using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.DTOS;

public class EventUpdateDTO
{
    [Required]
    public required int Id;
    public required string Name {get;set;}
    [Required]
    public required string Description {get;set;}
    [Required]
    public required string Location {get;set;}
    public string? AccessCode {get;set;}
    [Required]
    public required DateTime StartDate {get;set;}
    [Required]
    public required DateTime EndDate {get;set;}
    [Required]
    public required TimeSpan StartTime {get;set;}
    [Required]
    public required TimeSpan EndTime{get;set;}
}
