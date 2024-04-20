using DataServices;

namespace BusinessServices
{
    public class UserAccountServices
    {
        public bool VerifyUserAccount(string userId, string password)
        {
             UserDataServices userService = new UserDataServices();
            var result = userService.GetUsers(userId);

            return result != null && result.userPassword == password;
        }
    }
}
    
