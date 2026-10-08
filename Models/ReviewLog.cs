namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// (Future) One review of a flashcard, used for spaced repetition scheduling.
    /// Quality is the self-rated recall score (e.g. 0-5).
    /// </summary>
    public class ReviewLog
    {
        public int Id { get; set; }
        public int FlashcardId { get; set; }
        public int UserId { get; set; }
        public int Quality { get; set; }
        public DateTime ReviewedAt { get; set; } = DateTime.UtcNow;
        public DateTime NextReviewAt { get; set; }

        // Navigation properties
        public Flashcard? Flashcard { get; set; }
        public UserAccount? User { get; set; }
    }
}