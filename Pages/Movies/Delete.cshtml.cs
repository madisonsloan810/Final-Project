using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Final_Project.Pages.Movies;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;
    public DeleteModel(AppDbContext context)
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
    public async Task<IActionResult> OnPostAsync(int id)
    {
        var movieToDelete = await _context.Movies.FindAsync(id);
        if (movieToDelete == null)
            return NotFound();
        _context.Movies.Remove(movieToDelete);
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}
