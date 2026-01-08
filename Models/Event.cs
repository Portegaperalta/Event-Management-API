using System;
using System.ComponentModel.DataAnnotations;

namespace Event_Management_API.Models;

public class Event
{
    public int Id {get;set;}
    [Required(ErrorMessage = "Name is required.")]
    public required string Name {get;set;}
    [Required(ErrorMessage = "Description is required.")]
    public required string Description {get;set;}
    [Required(ErrorMessage = "Location is required.")]
    public required string Location {get;set;}
    public string? AccessCode {get;set;}
    [Required(ErrorMessage = "Start Date is required.")]
    public required DateTime StartDate {get;set;}
    [Required(ErrorMessage = "End Date is required.")]
    public required DateTime EndDate {get;set;}
    [Required(ErrorMessage = "StartTime is required.")]
    public required TimeSpan StartTime {get;set;}
    [Required(ErrorMessage = "End Time is required.")]
    public required TimeSpan EndTime{get;set;}
}
