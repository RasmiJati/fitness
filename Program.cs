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
                Console.WriteLine("Enter 1 to create: ");
                Console.WriteLine("Enter 2 to list:");
                Console.WriteLine("Enter 3 to delete");
                Console.WriteLine("Enter 4 to exit");
                Console.WriteLine("**************************");

                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        userController.Create();
                        break;
                    case "2":
                        userController.ShowAll();
                        break;
                    case "3":
                        userController.Delete();
                        break;
                    default:
                        return;
                }
            } while (choice != "0");
        }
    }
}
