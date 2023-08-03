using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Program
    {
        private static UserController userController;
        static void Main(string[] args)
        {
            userController = new UserController();
            string choice;
            do
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Choose the operation :");
                Console.WriteLine("Enter 1 for User: ");
                Console.WriteLine("Enter 2 for Routine:");
                Console.WriteLine("Enter 3 for Workout");
                Console.WriteLine("Enter 4 for Exercise");
                Console.WriteLine("Enter any key to exit");
                Console.WriteLine("**************************");

                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        userController.Options();
                        break;
                    case "2":
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        break;
                    default:
                        return;
                }
            } while (choice != "0");
        }
    }
}
