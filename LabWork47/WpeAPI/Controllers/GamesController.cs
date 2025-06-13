using DataBaseLibrary.DatabaseConnections;
using DataBaseLibrary.Models;
using DataBaseLibrary.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace WpeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController(IDbConnectionFactory factory) : ControllerBase
    {
        private readonly GamesRepository _repository = new(factory);

        [HttpGet]
        public async Task<IActionResult> GetGamesAsync()
        {
            try
            {
                return Ok(await Task.Run(() => _repository.GetAll()));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetGameById(int id)
        {
            try
            {
                var game = await Task.Run(() => _repository.GetById(id));

                if (game is null)
                    return NotFound("Игра не найдена по данному идентификатору.");

                return Ok(game);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateGame([FromBody] Game game)
        {
            try
            {
                await Task.Run(() => _repository.Create(game));

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGame([FromBody] Game game)
        {
            try
            {
                await Task.Run(() => _repository.Update(game));

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            try
            {
                if (await _repository.DeleteAsync(id) != 1)
                    return NotFound("Игра не найдена по данному идентификатору.");

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
