namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// (Future) A quiz generated from a FlashcardDeck.
    /// </summary>
    public class Quiz
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public string Title { get; set; } = string.Empty;

        // Navigation properties
        public ICollection<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();
        public FlashcardDeck? Deck { get; set; }
    }
}