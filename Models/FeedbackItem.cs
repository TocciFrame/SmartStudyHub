namespace SmartStudyHub.Models
{
    public class FeedbackItem
    {
        public string AuthorName { get; set; } = string.Empty;
        public string AuthorInitial { get; set; } = string.Empty;
        public string Timestamp { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }
}