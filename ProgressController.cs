using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class ProgressController
    {
        private UserRepository userRepository;
        private ProgressRepository progressRepository;
        public void Options(UserRepository userRepository, ProgressRepository progressRepository)
        {
            this.userRepository = userRepository;
            this.progressRepository = progressRepository;

            string choice;

            do
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Choose the operation :");
                Console.WriteLine("Enter 1 to Create");
                Console.WriteLine("Enter 2 to Show");
                Console.WriteLine("Enter 3 to Delete");
                Console.WriteLine("Enter 4 to Edit");
                Console.WriteLine("Enter 5 or any key to exit");
                Console.WriteLine("*****************************");
                Console.WriteLine("Enter your choice :");
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
            User user = null;
            string bodyPart = null;
            string measurementType = null;
            string measurementValue = null;

            while (id <= 0)
            {
                Console.WriteLine("Enter id :");
                id = Convert.ToInt32(Console.ReadLine());
            }

            List<User> userList = userRepository.ShowAll();
            if (user == null)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("User List :");
                foreach (User u in userList)
                    Console.WriteLine(u);
                Console.WriteLine("----------------------");

                int userId = 0;
                while (userId <= 0)
                {
                    Console.WriteLine("Enter user id :");
                    userId = Convert.ToInt32(Console.ReadLine());
                    user = userRepository.ShowById(userId);
                }
            }


            while (bodyPart == null)
            {
                Console.WriteLine("Enter body part: ");
                bodyPart = Console.ReadLine();
            }
            while (measurementType == null)
            {
                Console.WriteLine("Enter measurement type: ");
                measurementType = Console.ReadLine();
            }
            while (measurementValue == null)
            {
                Console.WriteLine("Enter measurement value : ");
                measurementValue = Console.ReadLine();
            }

            Progress progress = new Progress(id,user,bodyPart,measurementType,measurementValue);
            progressRepository.Create(progress);
            Console.WriteLine("Created Successfully");
        }

        public void ShowAll()
        {
            List<Progress> progresses = progressRepository.ShowAll();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Progress List :");
            Console.WriteLine("---------------------------");
            foreach (Progress progress in progresses)
            {
                Console.WriteLine(progress);
                Console.WriteLine("---------------------------");
            }
        }

        public void Delete()
        {
            int id;
            Console.WriteLine("Enter id to delete : ");
            id = Convert.ToInt32(Console.ReadLine());
            Progress progress = progressRepository.ShowById(id);
            if (progress == null)
            {
                Console.WriteLine("Progress with id " + id + " not found");
            }
            else
            {
                progressRepository.Delete(progress);
                Console.WriteLine("Deletion Sucessfull");
            }
        }

        public void Edit()
        {
            int id;
            User user = null;
            string bodyPart = null;
            string measurementType = null;
            string measurementValue = null;

            Console.WriteLine("Enter id to edit :");
            id = Convert.ToInt32(Console.ReadLine());

            Progress r = progressRepository.ShowById(id);
            if (r == null)
            {
                Console.WriteLine("Progress with id " + id + " not found");
            }

            else
            {
                List<User> userList = userRepository.ShowAll();
                if (user == null)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("User List :");
                    foreach (User u in userList)
                        Console.WriteLine(u);
                    Console.WriteLine("----------------------");

                    int userId = 0;
                    while (userId <= 0)
                    {
                        Console.WriteLine("Enter user id :");
                        userId = Convert.ToInt32(Console.ReadLine());
                        user = userRepository.ShowById(userId);
                    }
                }

                while (bodyPart == null)
                {
                    Console.WriteLine("Enter body part: ");
                    bodyPart = Console.ReadLine();
                }
                while (measurementType == null)
                {
                    Console.WriteLine("Enter measurement type: ");
                    measurementType = Console.ReadLine();
                }
                while (measurementValue == null)
                {
                    Console.WriteLine("Enter measurement value : ");
                    measurementValue = Console.ReadLine();
                }

                Progress progress = new Progress(id, user, bodyPart, measurementType, measurementValue);
                progressRepository.Edit(progress);
                Console.WriteLine("Edited Successfully");
            }
        }
    }
}
