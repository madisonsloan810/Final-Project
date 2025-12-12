using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace Final_Project.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    public IndexModel(AppDbContext context) => _context = context;
    public IList<Movie> Movies { get; set; } = new List<Movie>();
    public string? SearchString { get; set; }
    public string? SortOrder { get; set; }
    public int PageIndex { get; set; } = 1;
    public int TotalPages { get; set; }
    public const int PageSize = 10;
    public async Task OnGetAsync(string? searchString, string? sortOrder, int pageIndex = 1)
    {
        SearchString = searchString;
        SortOrder = sortOrder;
        PageIndex = pageIndex;
        var query = _context.Movies
            .Include(m => m.Ratings)
            .AsNoTracking()
            .AsQueryable();
        if (!string.IsNullOrWhiteSpace(SearchString))
            query = query.Where(m => m.Title.Contains(SearchString));
        query = SortOrder switch
        {
            "title_desc" => query.OrderByDescending(m => m.Title),
            "rating" => query.OrderBy(m => m.Ratings.Any() ? m.Ratings.Average(r => r.Score) : 0),
            "rating_desc" => query.OrderByDescending(m => m.Ratings.Any() ? m.Ratings.Average(r => r.Score) : 0),
            _ => query.OrderBy(m => m.Title)
        };
        var count = await query.CountAsync();
        TotalPages = (int)Math.Ceiling(count / (double)PageSize);
        Movies = await query
            .Skip((PageIndex - 1) * PageSize)
            .Take(PageSize)
            .ToListAsync();
    }
}
