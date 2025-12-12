using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace Final_Project.Pages.Movies;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    public IndexModel(AppDbContext context)
    {
        _context = context;
    }
    public IList<Movie> Movies { get; set; } = new List<Movie>();
    public async Task OnGetAsync()
    {
        Movies = await _context.Movies
            .Include(m => m.Ratings)
            .ToListAsync();
    }
}
