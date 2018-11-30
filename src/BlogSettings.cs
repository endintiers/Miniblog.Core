namespace Miniblog.Core
{
    public class BlogSettings
    {
        public string Owner { get; set; } = "Unearth AI";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 30;
    }
}
