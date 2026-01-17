using Event_Management_API.DTOS;
using Event_Management_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Event_Management_API.Controllers
{
     [Route("api/guests")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestsController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public async Task<IEnumerable<GuestDTO>> GetAll()
        {
            return await _guestService.GetAllDTOAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GuestDTO>> GetById([FromRoute] int id)
        {
            var guestDTO = await _guestService.GetByIdDTOAsync(id);

            return Ok(guestDTO);
        }

        //POST
        [HttpPost]
        public async Task<ActionResult> Post([FromForm] GuestCreationDTO guestCreationDTO)
        {
            await _guestService.CreateAsync(guestCreationDTO);
            return Created();
        }

        //PUT
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put([FromRoute] int id, GuestUpdateDTO guestUpdateDTO)
        {
            if (id != guestUpdateDTO.Id)
            {
                return BadRequest("Guest ids must match");
            }

           var guest =  await _guestService.GetByIdDTOAsync(id); 

            if (guest is null)
            {
                return NotFound($"User with id:{id} not found");
            }

            await _guestService.UpdateAsync(guestUpdateDTO);

            return NoContent();
        }
    }
}
