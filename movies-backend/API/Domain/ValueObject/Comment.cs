using Domain.Common;

namespace Domain.ValueObject;

public class Comment : Entity
{
    public int CommentId { get; set; }
    public string CommentText { get; set; }
    public decimal Score { get; set; }
    public int Liked { get; set; }
}