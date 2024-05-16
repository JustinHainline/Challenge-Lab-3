namespace Challenge_Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string correctUserId = "Justin Hainline";
            const string correctPassword = "mypassword";

            int attempts = 0;

            while (attempts < 3)
            {
                Console.WriteLine("Enter user ID: ");
                string userId = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                Console.WriteLine();

                if (userId == correctUserId && password == correctPassword) 
                {
                    Console.WriteLine("Authentication successfull!") ;
                    break;
                }

                else
                {
                    attempts++;
                    Console.WriteLine($"Incorrect credentials. Attempts remaining: {3 - attempts}");
                    Console.WriteLine($"Account Locked. {0 == attempts}");
                }

                
            }
        }
    }
}
