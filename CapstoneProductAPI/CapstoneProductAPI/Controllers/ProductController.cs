using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CapstoneProductAPI.APIContext;
using CapstoneProductAPI.Models;
using System.Net.Http;

namespace CapstoneProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public ProductController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        // GET: api/Product/Category/id
        [HttpGet("Category/{id}")]
        public async Task<ActionResult<List<Product>>> GetProductByCategory(int id)
        {
            var products = await _context.Products.Where(p => p.CategoryId == id).ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }
        // GET: api/Product/Discontinued/true
        [HttpGet("Discontinued/{discontinued}")]
        public async Task<ActionResult<List<Product>>> GetDiscontinuedProduct(bool discontinued)
        {
            var products = await _context.Products.Where(p => p.Discontinued == discontinued).ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // GET: api/Product/UnitPrice/maxPrice
        // GET: api/Product/UnitPrice/18.000
        [HttpGet("UnitPrice/{maxPrice}")]
        public async Task<ActionResult<List<Product>>> GetProductByMaxiPrice(decimal maxPrice)
        {
            var products = await _context.Products.Where(p => p.UnitPrice < maxPrice).ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }

        // PUT: api/Product/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Product
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
