namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// (Future) A tracked study period, optionally tied to a Subject and a FocusTrack.
    /// </summary>
    public class StudySession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? SubjectId { get; set; }
        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public int DurationMinutes { get; set; }
        public int? TrackId { get; set; }

        // Navigation properties
        public UserAccount? User { get; set; }
        public Subject? Subject { get; set; }
        public FocusTrack? Track { get; set; }
    }
}