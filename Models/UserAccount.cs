using SmartStudyHub.Models.Enums;

namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// Persistent account. Replaces the demo-only UserModel / User classes.
    /// </summary>
    public class UserAccount
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Student;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public ICollection<ReviewLog> ReviewLogs { get; set; } = new List<ReviewLog>();
        public ICollection<StudySession> StudySessions { get; set; } = new List<StudySession>();
        public UserPreference? Preference { get; set; }
        public ICollection<StudyReminder> Reminders { get; set; } = new List<StudyReminder>();
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public ICollection<StudyDocument> Documents { get; set; } = new List<StudyDocument>();
        public ICollection<FlashcardDeck> Decks { get; set; } = new List<FlashcardDeck>();
        public ICollection<ScratchpadNote> Notes { get; set; } = new List<ScratchpadNote>();
        public ICollection<FeedbackEntry> Feedback { get; set; } = new List<FeedbackEntry>();
    }
}