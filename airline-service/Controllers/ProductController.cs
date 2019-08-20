using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using airline_service.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace airline_service.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly AirlineDbContext _context;

        public ProductController(AirlineDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return new[]
            {
                new Product {Name = "Ana"},
                new Product {Name = "Felipe"}
            };
        }

        /*[HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var result = await _context.Product
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync();

            if (result == null) return NotFound();

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Create([FromBody] Product item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _context.Product.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new {id = item.Id}, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] Product item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id != item.Id) return BadRequest("request id and item id not equal");

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null) return NotFound();

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }*/
    }
}