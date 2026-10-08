namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// Persistent version of FlashcardModel (Question / Answer).
    /// </summary>
    public class Flashcard
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public int SortOrder { get; set; }

        // Navigation property
        public ICollection<ReviewLog> ReviewLogs { get; set; } = new List<ReviewLog>();
        public FlashcardDeck? Deck { get; set; }
    }
}