namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// A set of flashcards, optionally generated from a StudyDocument.
    /// </summary>
    public class FlashcardDeck
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? StudyDocumentId { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
        public UserAccount? User { get; set; }
        public StudyDocument? SourceDocument { get; set; }
        public ICollection<Flashcard> Cards { get; set; } = new List<Flashcard>();
    }
}