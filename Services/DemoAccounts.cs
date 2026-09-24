using SmartStudyHub.Models;

namespace SmartStudyHub.Services
{
    public static class DemoAccounts
    {
        public static readonly List<UserModel> Users = new()
        {
            new UserModel
            {
                Id = 1,
                Email = "user@admin.com",
                Password = "user123",
                Name = "Demo Admin"
            }
        };
    }
}