using Domain.Common;
using Domain.ValueObject;

namespace Domain;

public class UserInMovie : Entity
{
    public long UserMovieId { get; set; }
    
    public long UserId { get; set; }
    public long MovieId { get; set; }

    public bool ToWatch { get; set; }
    public bool SawIt { get; set; }
    
    
    private readonly IList<Comment> _comments = new List<Comment>();
    public ICollection<Comment> Comments => _comments.ToList();

    protected UserInMovie()
    {
    }

    internal static UserInMovie Create(long userId, long movieId)
    {
        return new UserInMovie()
        {
            UserId = userId,
            MovieId = movieId
        };
    }

    public void SetToWatch()
    {
        ToWatch = true;
    }

    public void SetComment(string comment, decimal score)
    {
        SawIt = true;
        ToWatch = false;

        var cmt = new Comment()
        {
            CommentText = comment,
            Score = score,
            Liked = 0
        };
        
        Comments.Add(cmt);
        

    }
}