using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.Models;

public class Event
{
    public int Id {get;set;}
    [Required]
    public required string Name {get;set;}
    [Required]
    public required string Description {get;set;}
    [Required]
    public required string Location {get;set;}
    [Required]
    public required DateTime StartDate {get;set;}
    [Required]
    public required DateTime EndDate {get;set;}
    [Required]
    public required TimeSpan StartTime {get;set;}
    [Required]
    public required TimeSpan EndTime{get;set;}
    public string? AccessCode {get;set;}
    public List<Guest> GuestList {get;set;} = [];
}
