namespace kritik.Models;

public class Review
{
    public int ReviewId { get; set; }
    public int Rating { get; set; }
    public string ReviewDescription { get; set; } = string.Empty;

    public int UserId { get; set; }
    public User User { get; set; } = default!;

    public int MovieId { get; set; }
    public Movie Movie { get; set; } = default!;

    // ICollection collection of objects it'll represent all comments assosicated with one review
    // we might be able to use list too 
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    
    // Constructor
    // create new comment object for review
    public Review()
    {
        Comments = new List<Comment>();
    }
}