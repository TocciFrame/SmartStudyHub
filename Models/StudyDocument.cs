namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// A file uploaded in the Document Summarizer (PDF, DOCX or TXT, max 20 MB).
    /// </summary>
    public class StudyDocument
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string FileExtension { get; set; } = string.Empty;
        public long FileSizeBytes { get; set; }
        public string SummaryText { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public UserAccount? User { get; set; }
        public ICollection<FlashcardDeck> Decks { get; set; } = new List<FlashcardDeck>();
    }
}