using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Final_Project.Pages.Ratings;

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;
    public CreateModel(AppDbContext context) => _context = context;
    [BindProperty]
    public Rating Rating { get; set; } = new();
    public SelectList MovieList { get; set; } = null!;
    public void OnGet(int? movieId)
    {
        MovieList = new SelectList(_context.Movies, "MovieID", "Title");
        if (movieId.HasValue)
            Rating.MovieID = movieId.Value;
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            MovieList = new SelectList(_context.Movies, "MovieID", "Title");
            return Page();
        }
        _context.Ratings.Add(Rating);
        await _context.SaveChangesAsync();
        return RedirectToPage("/Index");
    }
}
