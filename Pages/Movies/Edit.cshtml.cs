using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Final_Project.Pages.Movies;

public class EditModel : PageModel
{
    private readonly AppDbContext _context;
    public EditModel(AppDbContext context)
    {
        _context = context;
    }
    [BindProperty]
    public Movie? Movie { get; set; }
    public async Task<IActionResult> OnGetAsync(int id)
    {
        Movie = await _context.Movies.FindAsync(id);
        if (Movie == null)
            return NotFound();
        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid || Movie == null)
            return Page();
        var movieToUpdate = await _context.Movies.FindAsync(Movie.MovieID);
        if (movieToUpdate == null)
            return NotFound();
        movieToUpdate.Title = Movie.Title;
        movieToUpdate.Summary = Movie.Summary;
        movieToUpdate.ReleaseYear = Movie.ReleaseYear;
        movieToUpdate.PosterUrl = Movie.PosterUrl;
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}
