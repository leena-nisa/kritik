namespace kritik.Models;

public class Comment
{
    public int CommentId { get; set; } 
    public string CommentText { get; set; } = string.Empty; 

    public int ReviewId { get; set; }
    public Review Review { get; set; } = default!;

    public int UserId { get; set; }
    public User User { get; set; } = default!;
}