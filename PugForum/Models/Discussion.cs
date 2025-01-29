namespace PugForum.Models
{
    public class Discussion
    {
        int DiscussionId { get; set; }
        string Title { get; set; } = string.Empty;
        string Content { get; set; } = string.Empty;
        string ImageFileName { get; set; } = string.Empty;
        DateTime CreateDate { get; set; }
        List<Comment>? Comments { get; set; }

    }
}
