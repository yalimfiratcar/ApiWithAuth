using Microsoft.AspNetCore.Identity;

namespace ApiWithAuth.Models.Entities;

public class Tweet
{
    public int Id { get; set; }
    public string Body { get; set; }
    public string UserId { get; set; } // eğer sizde string olmazsa guid yapabilirsiniz
    public IdentityUser User { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
}