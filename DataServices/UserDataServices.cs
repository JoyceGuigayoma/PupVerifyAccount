using Model;

namespace DataServices
{
    public class UserDataServices
    {
        List<User> dummyAccount = new List<User>();
        
        public UserDataServices()
        {
            CreateUserData();
        } 

        public void  CreateUserData()
        {
            User user1 = new User { userId = "111-222-333", userAccount = "Joyce", userName = "JoyceGuigayoma", userPassword = "joyce123" };
            User user2 = new User { userId = "111-222-444", userAccount = "Hanna", userName = "HannaGuigayoma", userPassword = "hanna123" };
            User user3 = new User { userId = "111-222-555", userAccount = "Johan", userName = "JohanGuigayoma", userPassword = "johan123" };

            dummyAccount.Add(user1);
            dummyAccount.Add(user2);
            dummyAccount.Add(user3);
        }

        public User GetUsers(string userId)
        {
            foreach (var user in dummyAccount)
            {
                if (userId == user.userId)
                {
                    return user;
                }

            }
                return null;
            }
        }

    }

