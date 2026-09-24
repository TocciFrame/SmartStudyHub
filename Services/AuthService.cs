using SmartStudyHub.Models;

namespace SmartStudyHub.Services
{
    public class AuthService
    {
        public UserModel? CurrentUser { get; private set; } = null;
        public bool IsAuthenticated => CurrentUser != null;

        public bool Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // Find matching user from DemoAccounts list
            var user = DemoAccounts.Users.FirstOrDefault(u =>
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && u.Password == password);

            if (user != null)
            {
                CurrentUser = user;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}