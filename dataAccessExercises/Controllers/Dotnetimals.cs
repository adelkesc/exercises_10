using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.dataAccessExercises;

namespace dataAccessExercises
{
    [Route("api/Dotnetimals")] 
    [ApiController]
    public class Dotnetimals : ControllerBase
    {
        private readonly CatContext _context;

        public Dotnetimals(CatContext context)
        {
            _context = context;

            if(_context.Cats.Count() == 0)
            {
                _context.Cats.Add(new Cat { Name = "Fluffy", Price = 50});
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cat>>> GetCats()
        {
            return await _context.Cats.ToListAsync();
        }
    }
}