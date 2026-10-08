namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// (Future) A course or topic the student studies, used to categorize study sessions.
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ColorHex { get; set; } = "#3B82F6";

        // Navigation properties
        public ICollection<StudySession> StudySessions { get; set; } = new List<StudySession>();
        public UserAccount? User { get; set; }
    }
}