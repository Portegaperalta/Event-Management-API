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
        public async Task<ActionResult<EventDTO?>> GetById([FromRoute] int id)
        {
            var eventDTO = await _eventService.GetByIdAsync(id);

            if (eventDTO is null)
            {
                return NotFound();
            }

            return Ok(eventDTO);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromForm]EventCreationDTO eventCreationDTO)
        {
            await _eventService.CreateAsync(eventCreationDTO);
            return Created();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update([FromRoute]int id,[FromBody]EventUpdateDTO eventUpdateDTO)
        {
            if(id != eventUpdateDTO.Id)
            {
                return BadRequest("Event Ids must match");
            }

            await _eventService.UpdateAsync(eventUpdateDTO);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            bool isDeleted = await _eventService.DeleteAsync(id);

            if (isDeleted is false)
            {
                return NotFound($"The event with id:{id} was not found");
            }

            return NoContent();
        }
    }
}
