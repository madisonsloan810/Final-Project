using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models;

public class Rating
{
    public int RatingID { get; set; }
    [Range(1,5)]
    public int Score { get; set; }
    [StringLength(500)]
    public string? ReviewText { get; set; }
    [Required]
    public int MovieID { get; set; }
    public Movie? Movie { get; set; }
}
//Rating class