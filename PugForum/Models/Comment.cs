using Microsoft.VisualBasic;

namespace PugForum.Models
{
    public class Comment
    {
        int CommentId { get; set; }
        string Content { get; set; } = string.Empty;
        DateAndTime CreateDate { get; set; }
        int DiscussionId { get; set; }
        Discussion? Discussion { get; set; }

    }
}
