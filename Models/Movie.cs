namespace kritik.Models;

public class Movie
{
    public int MovieId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public float Rating { get; set; }
    public string Description { get; set; } = string.Empty;
    
    // A movie can have multiple reviews
    // We can do either ICollection or List
    // ICollection collection of objects it'll represent all reviews assosicated with a movie
    public ICollection<Review> Reviews { get; set; } = new List<Review>();

    // Constructor
    // create new review object for review
    public Movie()
    {
        Reviews = new List<Review>();
    }
}