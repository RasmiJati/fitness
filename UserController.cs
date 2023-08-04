using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class UserController
    {
        private UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }
        public void Options()
        {
            string choice;
            do
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Choose the operation :");
                Console.WriteLine("Enter 1 to create: ");
                Console.WriteLine("Enter 2 to list:");
                Console.WriteLine("Enter 3 to delete");
                Console.WriteLine("Enter 4 to edit");
                Console.WriteLine("Enter any key to exit");
                Console.WriteLine("**************************");

                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Create();
                        break;
                    case "2":
                        ShowAll();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "4":
                        Edit();
                        break;
                    default:
                        return;
                }
            } while (choice != "0");
        }
        public void Create()
        {
             int id = 0;
             string name = null;
             string email = null;
             string password = null;
             string profileInfo = null;

            Console.WriteLine("Enter id : ");
            if(id <= 0)
                id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter user name : ");
            if(name == null)
                name = Console.ReadLine();

            Console.WriteLine("Enter email : ");
            if (email == null)
                email = Console.ReadLine();

            Console.WriteLine("Enter password : ");
            if (password == null)
                password = Console.ReadLine();

            Console.WriteLine("Enter profile info : ");
            if (profileInfo == null)
                profileInfo = Console.ReadLine();

            User u = new User(id, name, email, password, profileInfo);
            userRepository.Create(u);
            Console.WriteLine("User added successfully");
        }

        public void ShowAll()
        {
            List<User> users = userRepository.ShowAll();
            Console.WriteLine("---------------------------");
            Console.WriteLine("User List :");
            Console.WriteLine("---------------------------");
            foreach(User u in users)
            {
                Console.WriteLine(u);
                Console.WriteLine("---------------------------");
            }
        }

        public void Delete()
        {
            int id;
            Console.WriteLine("Enter id to delete :");
            id = Convert.ToInt32(Console.ReadLine());
            User user = userRepository.ShowById(id);
            if(user == null)
            {
                Console.WriteLine("user of id " + id + " not found");
            }
            else
            {
                userRepository.Delete(user);
                Console.WriteLine("Deletion successfull");
            }
        }

        public void Edit()
        {
            int id;
            string name = null;
            string email = null;
            string password = null;
            string profileInfo = null;

            Console.WriteLine("Enter id to edit :");
            id = Convert.ToInt32(Console.ReadLine());

            User user = userRepository.ShowById(id);
            if (user == null)
            {
                Console.WriteLine("user with id " + id + " not found");
            }
            else
            {
                Console.WriteLine("Enter user name : ");
                if (name == null)
                    name = Console.ReadLine();

                Console.WriteLine("Enter email : ");
                if (email == null)
                    email = Console.ReadLine();

                Console.WriteLine("Enter password : ");
                if (password == null)
                    password = Console.ReadLine();

                Console.WriteLine("Enter profile info : ");
                if (profileInfo == null)
                    profileInfo = Console.ReadLine();
                
                User u = new User(id, name, email, password, profileInfo);
                userRepository.Edit(u);
                Console.WriteLine("Edited successfully");

            }
        }
    }
}
