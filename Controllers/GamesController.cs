using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Data;
using WebApplication4.EntityFramework;
using WebApplication4.Model;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : BaseController<Game, EntityFrameworkGameRepository>
    {
        public GamesController(EntityFrameworkGameRepository repository) : base(repository)
        {

        }
    }

    //[Route("api/[controller]")]
    //[ApiController]
    //public class GameController : ControllerBase
    //{
    //    private readonly WebApplication4Context _context;

    //    public GameController(WebApplication4Context context)
    //    {
    //        _context = context;
    //    }

    //    // GET: api/Games
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<Game>>> GetGame()
    //    {
    //        return await _context.Game.ToListAsync();
    //    }

    //    // GET: api/Games/5
    //    [HttpGet("{id}")]
    //    public async Task<ActionResult<Game>> GetGame(int id)
    //    {
    //        var game = await _context.Game.FindAsync(id);

    //        if (game == null)
    //        {
    //            return NotFound();
    //        }

    //        return game;
    //    }

    //    // PUT: api/Games/5
    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> PutGame(int id, Game game)
    //    {
    //        if (id != game.Id)
    //        {
    //            return BadRequest();
    //        }

    //        _context.Entry(game).State = EntityState.Modified;

    //        try
    //        {
    //            await _context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!GameExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return NoContent();
    //    }

    //    // POST: api/Games
    //    [HttpPost]
    //    public async Task<ActionResult<Game>> PostGame(Game game)
    //    {
    //        _context.Game.Add(game);
    //        await _context.SaveChangesAsync();

    //        return CreatedAtAction("GetGame", new { id = game.Id }, game);
    //    }

    //    // DELETE: api/Games/5
    //    [HttpDelete("{id}")]
    //    public async Task<ActionResult<Game>> DeleteGame(int id)
    //    {
    //        var game = await _context.Game.FindAsync(id);
    //        if (game == null)
    //        {
    //            return NotFound();
    //        }

    //        _context.Game.Remove(game);
    //        await _context.SaveChangesAsync();

    //        return game;
    //    }

    //    private bool GameExists(int id)
    //    {
    //        return _context.Game.Any(e => e.Id == id);
    //    }
    //}
}
