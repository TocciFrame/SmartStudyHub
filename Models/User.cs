namespace SmartStudyHub.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAuthenticated { get; set; }
    }
}