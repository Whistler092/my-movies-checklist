namespace Domain;

public class Movie
{
    public int MovieId { get; set; }
    public string OriginalTitle { get; set; }
    public string Title { get; set; }
    public string Overview { get; set; }
    public int TheMovieDbId { get; set; }
    public string Genre { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime LastUpdate { get; set; }
    
}