namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// Ambient focus-music track. Persistent version of TrackOption.
    /// </summary>
    public class FocusTrack
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public ICollection<StudySession> StudySessions { get; set; } = new List<StudySession>();
    }
}