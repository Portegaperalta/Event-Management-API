using Event_Management_API.DTOS;
using Event_Management_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Event_Management_API.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<IEnumerable<EventDTO>> GetAll()
        {
            var eventsDTO = await _eventService.GetAllAsync();

            return eventsDTO;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EventDTO?>> GetById([FromRoute] int eventId)
        {
            var eventDTO = await _eventService.GetByIdAsync(eventId);

            if (eventDTO is null)
            {
                return NotFound();
            }

            return Ok(eventDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Create(EventCreationDTO eventCreationDTO)
        {
            await _eventService.CreateAsync(eventCreationDTO);
            return Created();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(EventUpdateDTO eventUpdateDTO)
        {
            await _eventService.UpdateAsync(eventUpdateDTO);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int eventId)
        {
            var deletedRecords = await _eventService.DeleteAsync(eventId);

            if (deletedRecords == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
