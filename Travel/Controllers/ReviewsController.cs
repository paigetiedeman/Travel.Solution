using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Travel.Models;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private readonly TravelContext _db;

    public ReviewsController(TravelContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Review>>> Get()
    {
      return await _db.Reviews.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Review>> Post(Review review)
    {
      _db.Reviews.Add(review);await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = review.ReviewId }, review);
    }
  }
}