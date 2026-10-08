using SmartStudyHub.Models.Enums;

namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// Persistent version of FeedbackItem (rating 1-5, category, comment).
    /// </summary>
    public class FeedbackEntry
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public FeedbackCategory Category { get; set; } = FeedbackCategory.OverallExperience;
        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public UserAccount? User { get; set; }
    }
}