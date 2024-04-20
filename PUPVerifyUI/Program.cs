using BusinessServices;

namespace PUPPointsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your user ID: ");
            string userId = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            UserAccountServices userService = new UserAccountServices();
            bool result = userService.VerifyUserAccount(userId, password);

            if (result)
            {
                Console.WriteLine("Successfully Log in!");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}