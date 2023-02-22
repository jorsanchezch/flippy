using Microsoft.AspNetCore.Mvc;
using Domain.Repositories.Sample;
using Application.Requests.Sample;
using Application.Responses.Sample;
using Application.Commands.Sample;
using Application.Handlers.Sample;

namespace Application.Controllers.Sample
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        protected readonly IGenreRepository _repo;

        public GenreController(IGenreRepository repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public virtual async Task<IActionResult> Index()
        {
            var entities = await _repo.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Details(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(GenreRequest request)
        {
            var command = new CreateGenreCommand{
                request = request
            };

            var handler = new CreateGenreCommandHandler(this._repo);

            var response = await handler.Handle(command);

            return CreatedAtAction(nameof(Details), response);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update(int id, UpdateGenreRequest request)
        {
            if (id != request.Id)
                return BadRequest();

            var entity = await _repo.GetByIdAsync(id);

            if (entity == null)
                return NotFound();

            await _repo.UpdateAsync(entity);

            return Ok(new GenreResponse
                {
                    Name = entity.Name
                }
            );
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            await _repo.DeleteAsync(entity);
            return NoContent();
        }
    }
}