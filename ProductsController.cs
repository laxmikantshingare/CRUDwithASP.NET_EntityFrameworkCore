using CRUDAspNetEFCore.Context;
using CRUDAspNetEFCore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CRUDAspNetEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // READ ALL
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _context.Product.ToListAsync());
        }

        // READ BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // CREATE
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest();

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
                return NotFound();

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
