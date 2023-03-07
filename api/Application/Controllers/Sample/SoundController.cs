using Microsoft.AspNetCore.Mvc;
using Application.Requests.Sample;
using Application.Responses.Sample;
using Application.Services.Sample;

namespace Application.Controllers.Sample
{
    [ApiController]
    [Route("api/[controller]")]
    public class SoundController : Controller
    {
        private readonly ISoundService _service;

        public SoundController(ISoundService service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Index()
        {
            var entities = await _service.GetAllSoundsAsync();

            // Load the files. 
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Details(int id)
        {
            var entity = await _service.GetSoundByIdAsync(id);

            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create([FromForm]SoundRequest request)
        {
            var response = await _service.AddSoundAsync(request);

            return CreatedAtAction(nameof(Details), response);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(int id, UpdateSoundRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            var entity = await _service.GetSoundByIdAsync(id);

            if (entity == null)
                return NotFound();

            await _service.UpdateSoundAsync(request);

            return Ok(new SoundResponse
                {
                    Name = entity.Name,
                    Description = entity.Description,
                    Bpm = entity.Bpm,
                }
            );
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            _service.DeleteSoundAsync(id);
            return NoContent();
        }
    }
}