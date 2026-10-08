namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// (Future) Per-user settings. UserId is both primary key and foreign key
    /// (one-to-one with UserAccount).
    /// </summary>
    public class UserPreference
    {
        public int UserId { get; set; }
        public int? FavoriteTrackId { get; set; }
        public string Theme { get; set; } = "light";
        public int PomodoroMinutes { get; set; } = 25;

        // Navigation properties
        public UserAccount? User { get; set; }
        public FocusTrack? FavoriteTrack { get; set; }
    }
}