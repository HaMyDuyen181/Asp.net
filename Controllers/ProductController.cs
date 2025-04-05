using HaMyDuyen_2122110528.Data;
using HaMyDuyen_2122110528.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HaMyDuyen_2122110528.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
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
                return NotFound();

            return product;
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            // Tạo slug từ tên sản phẩm nếu chưa có
            if (string.IsNullOrEmpty(product.Slug))
            {
                product.Slug = GenerateSlug(product.Name);
            }

            // Đảm bảo CreatedDate được thiết lập nếu chưa có
            if (product.CreatedDate == default)
            {
                product.CreatedDate = DateTime.Now;
            }

            // Thêm sản phẩm vào DbContext
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            // Trả về sản phẩm đã được tạo, kèm theo URL của sản phẩm mới
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest();

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(p => p.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Hàm tạo slug từ tên sản phẩm
        private string GenerateSlug(string name)
        {
            // Thực hiện chuẩn hóa tên để tạo slug (có thể tùy chỉnh)
            return name.ToLower()
                       .Replace(" ", "-")       // Thay khoảng trắng bằng dấu gạch ngang
                       .Replace(".", "")        // Xóa dấu chấm
                       .Replace(",", "")        // Xóa dấu phẩy
                       .Replace("'", "")        // Xóa dấu nháy
                       .Replace("&", "and");    // Thay dấu "&" bằng "and"
        }
    }
}
