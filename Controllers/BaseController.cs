using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;

namespace WebApplication4.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
        {
            private readonly TRepository repository;

            public BaseController(TRepository repository)
            {
                this.repository = repository;
            }


            [HttpGet]
            public async Task<ActionResult<IEnumerable<TEntity>>> Get()
            {
                return await repository.GetAll();
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<TEntity>> Get(int id)
            {
                var game = await repository.Get(id);
                if (game == null)
                {
                    return NotFound();
                }
                return game;
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> Put(int id, TEntity game)
            {
                if (id != game.Id)
                {
                    return BadRequest();
                }
                await repository.Update(game);
                return NoContent();
            }


            [HttpPost]
            public async Task<ActionResult<TEntity>> Post(TEntity game)
            {
                await repository.Add(game);
                return CreatedAtAction("Get", new { id = game.Id }, game);
            }

            [HttpDelete("{id}")]
            public async Task<ActionResult<TEntity>> Delete(int id)
            {
                var game = await repository.Delete(id);
                if (game == null)
                {
                    return NotFound();
                }
                return game;
            }

        }
    }

