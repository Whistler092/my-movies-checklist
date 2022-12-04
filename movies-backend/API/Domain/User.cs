using Domain.ValueObject;

namespace Domain;

public class User
{
    public int UserId { get; set; }
    public string Email { get; set; }
    public DateTime CreateOn { get; set; }
    public DateTime LastLogin { get; set; }
    
    // Relationships
    private readonly IList<UserInMovie> _moviesIn = new List<UserInMovie>();
    public ICollection<UserInMovie> MoviesIn => _moviesIn.ToList();


    public void AddMovieToWatch(Movie movie)
    {
        var movieIn = UserInMovie.Create(UserId, movie.MovieId);

        movieIn.SetToWatch();
        
        MoviesIn.Add(movieIn);
        
    }

    public void AddReview(Movie movie, string comment, decimal score)
    {
        var movieIn = UserInMovie.Create(UserId, movie.MovieId);

        movieIn.SetComment(comment, score);
        
        MoviesIn.Add(movieIn);
    }
    
    
    
}