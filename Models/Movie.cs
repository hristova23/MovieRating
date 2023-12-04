using System.ComponentModel.DataAnnotations;

namespace MovieRating.Models;

public class Movie
{
    [Required]
    public string Name { get; set; }
    
    public string Description { get; set; }

    [Range(0,5)]
    public int Rating { get; set; }
}
