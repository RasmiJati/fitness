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
                Console.WriteLine("Id: "+u.id);
                Console.WriteLine("Name: "+u.name);
                Console.WriteLine("Email: "+u.email);
                Console.WriteLine("Password: " +u.password);
                Console.WriteLine("Profile Info: " +u.profileInfo);
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
