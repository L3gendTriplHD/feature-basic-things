using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApp.Api.Data;
using MyApp.Api.Models;

namespace MyApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostMetadatasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PostMetadatasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/postmetadatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostMetadata>>> GetPostMetadatas()
        {
            return await _context.PostMetadatas.Include(pm => pm.Post).ToListAsync();
        }

        // GET: api/postmetadatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PostMetadata>> GetPostMetadata(int id)
        {
            var metadata = await _context.PostMetadatas
                .Include(pm => pm.Post)
                .FirstOrDefaultAsync(pm => pm.Id == id);

            if (metadata == null)
                return NotFound();

            return metadata;
        }

        // POST: api/postmetadatas
        [HttpPost]
        public async Task<ActionResult<PostMetadata>> CreatePostMetadata(PostMetadata metadata)
        {
            _context.PostMetadatas.Add(metadata);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPostMetadata), new { id = metadata.Id }, metadata);
        }

        // PUT: api/postmetadatas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePostMetadata(int id, PostMetadata metadata)
        {
            if (id != metadata.Id)
                return BadRequest();

            _context.Entry(metadata).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/postmetadatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostMetadata(int id)
        {
            var metadata = await _context.PostMetadatas.FindAsync(id);
            if (metadata == null)
                return NotFound();

            _context.PostMetadatas.Remove(metadata);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}