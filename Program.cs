using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController userController = new UserController();
            RoutineController routineController = new RoutineController();
            UserRepository userRepository = new UserRepository();
            RoutineRepository routineRepository = new RoutineRepository();

            string choice;
            do
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Choose the operation :");
                Console.WriteLine("Enter 1 for User: ");
                Console.WriteLine("Enter 2 for Routine:");
                Console.WriteLine("Enter 3 for Workout");
                Console.WriteLine("Enter 4 for Exercise");
                Console.WriteLine("Enter 5 or any key to exit");
                Console.WriteLine("**************************");

                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        userController.Options(userRepository);
                        break;
                    case "2":
                        routineController.Options(userRepository,routineRepository);
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
