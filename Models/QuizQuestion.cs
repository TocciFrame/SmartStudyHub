namespace SmartStudyHub.Models.Entities
{
    /// <summary>
    /// (Future) A single question belonging to a Quiz.
    /// </summary>
    public class QuizQuestion
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Prompt { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; } = string.Empty;

        // Navigation properties
        public Quiz? Quiz { get; set; }
    }
}