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
    }
}
