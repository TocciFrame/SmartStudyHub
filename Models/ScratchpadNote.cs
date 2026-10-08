namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// Quick Scratchpad content, saved per user instead of only downloaded as .txt.
    /// </summary>
    public class ScratchpadNote
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public UserAccount? User { get; set; }
    }
}