using System.ComponentModel.DataAnnotations;
namespace Final_Project.Models;

public class Movie
{
    public int MovieID { get; set; }
    [Required, StringLength(100)]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Summary { get; set; } = string.Empty;
    [Range(1880, 2100)]
    public int ReleaseYear { get; set; }
    [Required, StringLength(300)]
    public string PosterUrl { get; set; } = string.Empty;
    public List<Rating> Ratings { get; set; } = new();
}
//Movie class