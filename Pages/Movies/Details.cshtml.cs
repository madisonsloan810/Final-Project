using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace Final_Project.Pages.Movies;

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;
    public DetailsModel(AppDbContext context)
    {
        _context = context;
    }
    public Movie? Movie { get; set; } = null!;
    public async Task<IActionResult> OnGetAsync(int id)
    {
        Movie = await _context.Movies
            .Include(m => m.Ratings)
            .FirstOrDefaultAsync(m => m.MovieID == id);
        if (Movie == null) return NotFound();
        return Page();
    }
}
