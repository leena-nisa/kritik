namespace kritik.Models;

public class User
{
    public int UID { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; // ?

    // ICollection collection of objects it'll represent all reviews and comments assosicated with one user
    public ICollection<Review> Reviews { get; set; } = new List<Review>(); 
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    // Constructor 
    // create new comment and review object for user
    // public User()
    // {
    //     Reviews = new List<Review>();
    //     Comments = new List<Comment>();
    // }
}
