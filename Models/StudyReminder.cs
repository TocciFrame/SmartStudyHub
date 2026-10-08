namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// (Future) A scheduled reminder to study or review.
    /// </summary>
    public class StudyReminder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime RemindAt { get; set; }

        // Navigation properties
        public UserAccount? User { get; set; }
    }
}