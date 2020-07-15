using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Data;
using Teste.Models;

namespace Teste.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        // private DataContext _context;
        // public CategoryController(DataContext context) { _context = context; }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context) =>
            await context.Categories
            .ToListAsync();

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> GetById([FromServices] DataContext context, int id) =>
            await context.Categories
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post([FromServices] DataContext context, [FromBody] Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                await context.SaveChangesAsync();
                return category;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
