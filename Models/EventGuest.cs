using System;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_API.Models;

[PrimaryKey(nameof(EventId),nameof(GuestId))]
public class EventGuest
{
    public int EventId {get;set;}
    public int GuestId {get;set;}
    public string EventStatus {get;set;} = "default";
    public string Rspv {get;set;} = "not invited";
    public Guest? Guest {get;set;}
    public Event? Event {get;set;}
}
